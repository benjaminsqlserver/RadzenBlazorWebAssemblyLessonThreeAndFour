using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CaApp.Data;

namespace CaApp
{
    public partial class ExportConDataController : ExportController
    {
        private readonly ConDataContext context;

        public ExportConDataController(ConDataContext context)
        {
            this.context = context;
        }
        [HttpGet("/export/ConData/countries/csv")]
        [HttpGet("/export/ConData/countries/csv(fileName='{fileName}')")]
        public FileStreamResult ExportCountriesToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.Countries, Request.Query), fileName);
        }

        [HttpGet("/export/ConData/countries/excel")]
        [HttpGet("/export/ConData/countries/excel(fileName='{fileName}')")]
        public FileStreamResult ExportCountriesToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.Countries, Request.Query), fileName);
        }
        [HttpGet("/export/ConData/devicecodes/csv")]
        [HttpGet("/export/ConData/devicecodes/csv(fileName='{fileName}')")]
        public FileStreamResult ExportDeviceCodesToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.DeviceCodes, Request.Query), fileName);
        }

        [HttpGet("/export/ConData/devicecodes/excel")]
        [HttpGet("/export/ConData/devicecodes/excel(fileName='{fileName}')")]
        public FileStreamResult ExportDeviceCodesToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.DeviceCodes, Request.Query), fileName);
        }
        [HttpGet("/export/ConData/genders/csv")]
        [HttpGet("/export/ConData/genders/csv(fileName='{fileName}')")]
        public FileStreamResult ExportGendersToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.Genders, Request.Query), fileName);
        }

        [HttpGet("/export/ConData/genders/excel")]
        [HttpGet("/export/ConData/genders/excel(fileName='{fileName}')")]
        public FileStreamResult ExportGendersToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.Genders, Request.Query), fileName);
        }
        [HttpGet("/export/ConData/persistedgrants/csv")]
        [HttpGet("/export/ConData/persistedgrants/csv(fileName='{fileName}')")]
        public FileStreamResult ExportPersistedGrantsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.PersistedGrants, Request.Query), fileName);
        }

        [HttpGet("/export/ConData/persistedgrants/excel")]
        [HttpGet("/export/ConData/persistedgrants/excel(fileName='{fileName}')")]
        public FileStreamResult ExportPersistedGrantsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.PersistedGrants, Request.Query), fileName);
        }
        [HttpGet("/export/ConData/students/csv")]
        [HttpGet("/export/ConData/students/csv(fileName='{fileName}')")]
        public FileStreamResult ExportStudentsToCSV(string fileName = null)
        {
            return ToCSV(ApplyQuery(context.Students, Request.Query), fileName);
        }

        [HttpGet("/export/ConData/students/excel")]
        [HttpGet("/export/ConData/students/excel(fileName='{fileName}')")]
        public FileStreamResult ExportStudentsToExcel(string fileName = null)
        {
            return ToExcel(ApplyQuery(context.Students, Request.Query), fileName);
        }
    }
}
