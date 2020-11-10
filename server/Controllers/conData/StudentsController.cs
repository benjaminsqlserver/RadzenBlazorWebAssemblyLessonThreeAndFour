using System;
using System.Net;
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNet.OData.Query;



namespace CaApp.Controllers.ConData
{
  using Models;
  using Data;
  using Models.ConData;

  [ODataRoutePrefix("odata/conData/Students")]
  [Route("mvc/odata/conData/Students")]
  public partial class StudentsController : ODataController
  {
    private Data.ConDataContext context;

    public StudentsController(Data.ConDataContext context)
    {
      this.context = context;
    }
    // GET /odata/ConData/Students
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.ConData.Student> GetStudents()
    {
      var items = this.context.Students.AsQueryable<Models.ConData.Student>();
      this.OnStudentsRead(ref items);

      return items;
    }

    partial void OnStudentsRead(ref IQueryable<Models.ConData.Student> items);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{StudentID}")]
    public SingleResult<Student> GetStudent(Int64 key)
    {
        var items = this.context.Students.Where(i=>i.StudentID == key);
        return SingleResult.Create(items);
    }
    partial void OnStudentDeleted(Models.ConData.Student item);
    partial void OnAfterStudentDeleted(Models.ConData.Student item);

    [HttpDelete("{StudentID}")]
    public IActionResult DeleteStudent(Int64 key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Students
                .Where(i => i.StudentID == key)
                .FirstOrDefault();

            if (item == null)
            {
                return BadRequest();
            }

            this.OnStudentDeleted(item);
            this.context.Students.Remove(item);
            this.context.SaveChanges();
            this.OnAfterStudentDeleted(item);

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnStudentUpdated(Models.ConData.Student item);
    partial void OnAfterStudentUpdated(Models.ConData.Student item);

    [HttpPut("{StudentID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutStudent(Int64 key, [FromBody]Models.ConData.Student newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (newItem == null || (newItem.StudentID != key))
            {
                return BadRequest();
            }

            this.OnStudentUpdated(newItem);
            this.context.Students.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Students.Where(i => i.StudentID == key);
            Request.QueryString = Request.QueryString.Add("$expand", "Gender,Country,Country1,Country2,Country3");
            this.OnAfterStudentUpdated(newItem);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    [HttpPatch("{StudentID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PatchStudent(Int64 key, [FromBody]Delta<Models.ConData.Student> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Students.Where(i => i.StudentID == key).FirstOrDefault();

            if (item == null)
            {
                return BadRequest();
            }

            patch.Patch(item);

            this.OnStudentUpdated(item);
            this.context.Students.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Students.Where(i => i.StudentID == key);
            Request.QueryString = Request.QueryString.Add("$expand", "Gender,Country,Country1,Country2,Country3");
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnStudentCreated(Models.ConData.Student item);
    partial void OnAfterStudentCreated(Models.ConData.Student item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.ConData.Student item)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (item == null)
            {
                return BadRequest();
            }

            this.OnStudentCreated(item);
            this.context.Students.Add(item);
            this.context.SaveChanges();

            var key = item.StudentID;

            var itemToReturn = this.context.Students.Where(i => i.StudentID == key);

            Request.QueryString = Request.QueryString.Add("$expand", "Gender,Country,Country1,Country2,Country3");

            this.OnAfterStudentCreated(item);

            return new ObjectResult(SingleResult.Create(itemToReturn))
            {
                StatusCode = 201
            };
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
