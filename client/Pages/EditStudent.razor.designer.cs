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
    public partial class EditStudentComponent : ComponentBase
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

        [Parameter]
        public dynamic StudentID { get; set; }

        CaApp.Models.ConData.Student _student;
        protected CaApp.Models.ConData.Student student
        {
            get
            {
                return _student;
            }
            set
            {
                if (!object.Equals(_student, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "student", NewValue = value, OldValue = _student };
                    _student = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<CaApp.Models.ConData.Gender> _getGendersResult;
        protected IEnumerable<CaApp.Models.ConData.Gender> getGendersResult
        {
            get
            {
                return _getGendersResult;
            }
            set
            {
                if (!object.Equals(_getGendersResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getGendersResult", NewValue = value, OldValue = _getGendersResult };
                    _getGendersResult = value;
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
            var conDataGetStudentByStudentIdResult = await ConData.GetStudentByStudentId(studentId:StudentID);
            student = conDataGetStudentByStudentIdResult;

            var conDataGetGendersResult = await ConData.GetGenders();
            getGendersResult = conDataGetGendersResult.Value.AsODataEnumerable();

            var conDataGetCountriesResult = await ConData.GetCountries();
            getCountriesResult = conDataGetCountriesResult.Value.AsODataEnumerable();
        }

        protected async System.Threading.Tasks.Task Form0Submit(CaApp.Models.ConData.Student args)
        {
            try
            {
                var conDataUpdateStudentResult = await ConData.UpdateStudent(studentId:StudentID, student:student);
                DialogService.Close(student);
            }
            catch (System.Exception conDataUpdateStudentException)
            {
                NotificationService.Notify(NotificationSeverity.Error, $"Error", $"Unable to update Student");
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
