
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Web;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Components;
using Radzen;
using CaApp.Models.ConData;

namespace CaApp
{
    public partial class ConDataService
    {
        private readonly HttpClient httpClient;
        private readonly Uri baseUri;
        private readonly NavigationManager navigationManager;
        public ConDataService(NavigationManager navigationManager, HttpClient httpClient, IConfiguration configuration)
        {
            this.httpClient = httpClient;

            this.navigationManager = navigationManager;
            this.baseUri = new Uri($"{navigationManager.BaseUri}odata/conData/");
        }

        public async System.Threading.Tasks.Task ExportCountriesToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/condata/countries/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/condata/countries/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportCountriesToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/condata/countries/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/condata/countries/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetCountries(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<ODataServiceResult<Models.ConData.Country>> GetCountries(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string))
        {
            var uri = new Uri(baseUri, $"Countries");
            uri = uri.GetODataUri(filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:null, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetCountries(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ODataServiceResult<Models.ConData.Country>>();
        }
        partial void OnCreateCountry(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Models.ConData.Country> CreateCountry(Models.ConData.Country country = default(Models.ConData.Country))
        {
            var uri = new Uri(baseUri, $"Countries");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, uri);

            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(country), Encoding.UTF8, "application/json");

            OnCreateCountry(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<Models.ConData.Country>();
        }

        public async System.Threading.Tasks.Task ExportDeviceCodesToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/condata/devicecodes/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/condata/devicecodes/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportDeviceCodesToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/condata/devicecodes/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/condata/devicecodes/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetDeviceCodes(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<ODataServiceResult<Models.ConData.DeviceCode>> GetDeviceCodes(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string))
        {
            var uri = new Uri(baseUri, $"DeviceCodes");
            uri = uri.GetODataUri(filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:null, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetDeviceCodes(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ODataServiceResult<Models.ConData.DeviceCode>>();
        }
        partial void OnCreateDeviceCode(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Models.ConData.DeviceCode> CreateDeviceCode(Models.ConData.DeviceCode deviceCode = default(Models.ConData.DeviceCode))
        {
            var uri = new Uri(baseUri, $"DeviceCodes");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, uri);

            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(deviceCode), Encoding.UTF8, "application/json");

            OnCreateDeviceCode(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<Models.ConData.DeviceCode>();
        }

        public async System.Threading.Tasks.Task ExportGendersToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/condata/genders/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/condata/genders/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportGendersToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/condata/genders/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/condata/genders/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetGenders(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<ODataServiceResult<Models.ConData.Gender>> GetGenders(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string))
        {
            var uri = new Uri(baseUri, $"Genders");
            uri = uri.GetODataUri(filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:null, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetGenders(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ODataServiceResult<Models.ConData.Gender>>();
        }
        partial void OnCreateGender(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Models.ConData.Gender> CreateGender(Models.ConData.Gender gender = default(Models.ConData.Gender))
        {
            var uri = new Uri(baseUri, $"Genders");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, uri);

            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(gender), Encoding.UTF8, "application/json");

            OnCreateGender(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<Models.ConData.Gender>();
        }

        public async System.Threading.Tasks.Task ExportPersistedGrantsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/condata/persistedgrants/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/condata/persistedgrants/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportPersistedGrantsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/condata/persistedgrants/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/condata/persistedgrants/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetPersistedGrants(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<ODataServiceResult<Models.ConData.PersistedGrant>> GetPersistedGrants(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string))
        {
            var uri = new Uri(baseUri, $"PersistedGrants");
            uri = uri.GetODataUri(filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:null, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetPersistedGrants(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ODataServiceResult<Models.ConData.PersistedGrant>>();
        }
        partial void OnCreatePersistedGrant(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Models.ConData.PersistedGrant> CreatePersistedGrant(Models.ConData.PersistedGrant persistedGrant = default(Models.ConData.PersistedGrant))
        {
            var uri = new Uri(baseUri, $"PersistedGrants");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, uri);

            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(persistedGrant), Encoding.UTF8, "application/json");

            OnCreatePersistedGrant(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<Models.ConData.PersistedGrant>();
        }

        public async System.Threading.Tasks.Task ExportStudentsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/condata/students/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/condata/students/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async System.Threading.Tasks.Task ExportStudentsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/condata/students/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/condata/students/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }
        partial void OnGetStudents(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<ODataServiceResult<Models.ConData.Student>> GetStudents(string filter = default(string), string orderby = default(string), string expand = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), string format = default(string))
        {
            var uri = new Uri(baseUri, $"Students");
            uri = uri.GetODataUri(filter:filter, top:top, skip:skip, orderby:orderby, expand:expand, select:null, count:count);

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetStudents(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<ODataServiceResult<Models.ConData.Student>>();
        }
        partial void OnCreateStudent(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Models.ConData.Student> CreateStudent(Models.ConData.Student student = default(Models.ConData.Student))
        {
            var uri = new Uri(baseUri, $"Students");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, uri);

            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(student), Encoding.UTF8, "application/json");

            OnCreateStudent(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<Models.ConData.Student>();
        }
        partial void OnDeleteCountry(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> DeleteCountry(int? countryId = default(int?))
        {
            var uri = new Uri(baseUri, $"Countries({countryId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);

            OnDeleteCountry(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnGetCountryByCountryId(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Models.ConData.Country> GetCountryByCountryId(int? countryId = default(int?))
        {
            var uri = new Uri(baseUri, $"Countries({countryId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetCountryByCountryId(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<Models.ConData.Country>();
        }
        partial void OnUpdateCountry(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> UpdateCountry(int? countryId = default(int?), Models.ConData.Country country = default(Models.ConData.Country))
        {
            var uri = new Uri(baseUri, $"Countries({countryId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Patch, uri);

            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(country), Encoding.UTF8, "application/json");

            OnUpdateCountry(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnDeleteDeviceCode(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> DeleteDeviceCode(string userCode = default(string))
        {
            var uri = new Uri(baseUri, $"DeviceCodes('{HttpUtility.UrlEncode(userCode)}')");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);

            OnDeleteDeviceCode(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnGetDeviceCodeByUserCode(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Models.ConData.DeviceCode> GetDeviceCodeByUserCode(string userCode = default(string))
        {
            var uri = new Uri(baseUri, $"DeviceCodes('{HttpUtility.UrlEncode(userCode)}')");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetDeviceCodeByUserCode(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<Models.ConData.DeviceCode>();
        }
        partial void OnUpdateDeviceCode(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> UpdateDeviceCode(string userCode = default(string), Models.ConData.DeviceCode deviceCode = default(Models.ConData.DeviceCode))
        {
            var uri = new Uri(baseUri, $"DeviceCodes('{HttpUtility.UrlEncode(userCode)}')");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Patch, uri);

            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(deviceCode), Encoding.UTF8, "application/json");

            OnUpdateDeviceCode(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnDeleteGender(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> DeleteGender(int? genderId = default(int?))
        {
            var uri = new Uri(baseUri, $"Genders({genderId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);

            OnDeleteGender(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnGetGenderByGenderId(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Models.ConData.Gender> GetGenderByGenderId(int? genderId = default(int?))
        {
            var uri = new Uri(baseUri, $"Genders({genderId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetGenderByGenderId(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<Models.ConData.Gender>();
        }
        partial void OnUpdateGender(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> UpdateGender(int? genderId = default(int?), Models.ConData.Gender gender = default(Models.ConData.Gender))
        {
            var uri = new Uri(baseUri, $"Genders({genderId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Patch, uri);

            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(gender), Encoding.UTF8, "application/json");

            OnUpdateGender(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnDeletePersistedGrant(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> DeletePersistedGrant(string key = default(string))
        {
            var uri = new Uri(baseUri, $"PersistedGrants('{HttpUtility.UrlEncode(key)}')");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);

            OnDeletePersistedGrant(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnGetPersistedGrantByKey(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Models.ConData.PersistedGrant> GetPersistedGrantByKey(string key = default(string))
        {
            var uri = new Uri(baseUri, $"PersistedGrants('{HttpUtility.UrlEncode(key)}')");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetPersistedGrantByKey(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<Models.ConData.PersistedGrant>();
        }
        partial void OnUpdatePersistedGrant(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> UpdatePersistedGrant(string key = default(string), Models.ConData.PersistedGrant persistedGrant = default(Models.ConData.PersistedGrant))
        {
            var uri = new Uri(baseUri, $"PersistedGrants('{HttpUtility.UrlEncode(key)}')");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Patch, uri);

            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(persistedGrant), Encoding.UTF8, "application/json");

            OnUpdatePersistedGrant(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnDeleteStudent(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> DeleteStudent(Int64? studentId = default(Int64?))
        {
            var uri = new Uri(baseUri, $"Students({studentId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);

            OnDeleteStudent(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
        partial void OnGetStudentByStudentId(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<Models.ConData.Student> GetStudentByStudentId(Int64? studentId = default(Int64?))
        {
            var uri = new Uri(baseUri, $"Students({studentId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            OnGetStudentByStudentId(httpRequestMessage);

            var response = await httpClient.SendAsync(httpRequestMessage);

            return await response.ReadAsync<Models.ConData.Student>();
        }
        partial void OnUpdateStudent(HttpRequestMessage requestMessage);


        public async System.Threading.Tasks.Task<HttpResponseMessage> UpdateStudent(Int64? studentId = default(Int64?), Models.ConData.Student student = default(Models.ConData.Student))
        {
            var uri = new Uri(baseUri, $"Students({studentId})");

            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Patch, uri);

            httpRequestMessage.Content = new StringContent(ODataJsonSerializer.Serialize(student), Encoding.UTF8, "application/json");

            OnUpdateStudent(httpRequestMessage);
            return await httpClient.SendAsync(httpRequestMessage);
        }
    }
}
