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
    public partial class StudentComponent : ComponentBase
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
        protected RadzenGrid<CaApp.Models.ConData.Student> grid0;

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

        IEnumerable<CaApp.Models.ConData.Student> _getStudentsResult;
        protected IEnumerable<CaApp.Models.ConData.Student> getStudentsResult
        {
            get
            {
                return _getStudentsResult;
            }
            set
            {
                if (!object.Equals(_getStudentsResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getStudentsResult", NewValue = value, OldValue = _getStudentsResult };
                    _getStudentsResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getStudentsCount;
        protected int getStudentsCount
        {
            get
            {
                return _getStudentsCount;
            }
            set
            {
                if (!object.Equals(_getStudentsCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getStudentsCount", NewValue = value, OldValue = _getStudentsCount };
                    _getStudentsCount = value;
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
            var dialogResult = await DialogService.OpenAsync<AddStudent>("Add Student", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Splitbutton0Click(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await ConData.ExportStudentsToCSV(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Student");

            }

            if (args?.Value == "xlsx")
            {
                await ConData.ExportStudentsToExcel(new Query() { Filter = $@"{grid0.Query.Filter}", OrderBy = $"{grid0.Query.OrderBy}" }, $"Student");

            }
        }

        protected async System.Threading.Tasks.Task Grid0LoadData(LoadDataArgs args)
        {
            try
            {
                var conDataGetStudentsResult = await ConData.GetStudents(filter:$@"(contains(SchoolAdmissionNumber,""{search}"") or contains(Surname,""{search}"") or contains(FirstName,""{search}"") or contains(OtherNames,""{search}"") or contains(Username,""{search}"") or contains(Password,""{search}"") or contains(ConfirmPassword,""{search}"") or contains(FatherSurname,""{search}"") or contains(FatherFirstName,""{search}"") or contains(FatherOtherNames,""{search}"") or contains(FatherEmail,""{search}"") or contains(FatherTelephone,""{search}"") or contains(FatherProfession,""{search}"") or contains(FatherOffice,""{search}"") or contains(FatherResidentialAddress,""{search}"") or contains(MotherSurname,""{search}"") or contains(MotherFirstName,""{search}"") or contains(MotherOtherNames,""{search}"") or contains(MotherEmail,""{search}"") or contains(MotherTelephone,""{search}"") or contains(MotherProfession,""{search}"") or contains(MotherOffice,""{search}"") or contains(MotherResidentialAddress,""{search}"") or contains(GuardianSurname,""{search}"") or contains(GuardianFirstName,""{search}"") or contains(GuardianOtherNames,""{search}"") or contains(GuardianEmail,""{search}"") or contains(GuardianTelephone,""{search}"") or contains(GuardianProfession,""{search}"") or contains(GuardianOffice,""{search}"") or contains(GuardianResidentialAddress,""{search}"")) and {(string.IsNullOrEmpty(args.Filter)? "true" : args.Filter)}", orderby:$"{args.OrderBy}", expand:$"Gender,Country,Country1,Country2,Country3", top:args.Top, skip:args.Skip, count:args.Top != null && args.Skip != null);
                getStudentsResult = conDataGetStudentsResult.Value.AsODataEnumerable();

                getStudentsCount = conDataGetStudentsResult.Count;
            }
            catch (System.Exception conDataGetStudentsException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to load Students");
            }
        }

        protected async System.Threading.Tasks.Task Grid0RowSelect(CaApp.Models.ConData.Student args)
        {
            var dialogResult = await DialogService.OpenAsync<EditStudent>("Edit Student", new Dictionary<string, object>() { {"StudentID", args.StudentID} });
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var conDataDeleteStudentResult = await ConData.DeleteStudent(studentId:data.StudentID);
                    if (conDataDeleteStudentResult != null)
                    {
                        await grid0.Reload();
                    }
                }
            }
            catch (System.Exception conDataDeleteStudentException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to delete Student");
            }
        }
    }
}
