using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using CaApp.Models.ConData;
using Microsoft.AspNetCore.Identity;
using CaApp.Models;
using CaApp.Client.Pages;

namespace CaApp.Pages
{
    public partial class CountriesComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        public void Reload()
        {
            InvokeAsync(StateHasChanged);
        }

        public void OnPropertyChanged(PropertyChangedEventArgs args)
        {
        }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected TooltipService TooltipService { get; set; }

        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected SecurityService Security { get; set; }


        [Inject]
        protected ConDataService ConData { get; set; }
        protected RadzenGrid<CaApp.Models.ConData.Country> grid0;

        string _search;
        protected string search
        {
            get
            {
                return _search;
            }
            set
            {
                if (!object.Equals(_search, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "search", NewValue = value, OldValue = _search };
                    _search = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<CaApp.Models.ConData.Country> _getCountriesResult;
        protected IEnumerable<CaApp.Models.ConData.Country> getCountriesResult
        {
            get
            {
                return _getCountriesResult;
            }
            set
            {
                if (!object.Equals(_getCountriesResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getCountriesResult", NewValue = value, OldValue = _getCountriesResult };
                    _getCountriesResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getCountriesCount;
        protected int getCountriesCount
        {
            get
            {
                return _getCountriesCount;
            }
            set
            {
                if (!object.Equals(_getCountriesCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getCountriesCount", NewValue = value, OldValue = _getCountriesCount };
                    _getCountriesCount = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            if (!await Security.IsAuthenticatedAsync())
            {
                UriHelper.NavigateTo("Login", true);
            }
            else
            {
                await Load();
            }

        }
        protected async System.Threading.Tasks.Task Load()
        {
            if (string.IsNullOrEmpty(search)) {
                search = "";
            }
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddCountry>("Add Country", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Splitbutton0Click(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await ConData.ExportCountriesToCSV(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Countries");

            }

            if (args?.Value == "xlsx")
            {
                await ConData.ExportCountriesToExcel(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Countries");

            }
        }

        protected async System.Threading.Tasks.Task Grid0LoadData(LoadDataArgs args)
        {
            try
            {
                var conDataGetCountriesResult = await ConData.GetCountries(filter:$@"(contains(CountryName,""{search}"")) and {(string.IsNullOrEmpty(args.Filter)? "true" : args.Filter)}", orderby:$"{args.OrderBy}", top:args.Top, skip:args.Skip, count:args.Top != null && args.Skip != null);
                getCountriesResult = conDataGetCountriesResult.Value.AsODataEnumerable();

                getCountriesCount = conDataGetCountriesResult.Count;
            }
            catch (System.Exception conDataGetCountriesException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to load Countries");
            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(CaApp.Models.ConData.Country args)
        {
            var dialogResult = await DialogService.OpenAsync<EditCountry>("Edit Country", new Dictionary<string, object>() { {"CountryID", args.CountryID} });
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var conDataDeleteCountryResult = await ConData.DeleteCountry(countryId:data.CountryID);
                    if (conDataDeleteCountryResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception conDataDeleteCountryException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete Country");
            }
        }
    }
}
