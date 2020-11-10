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

  [ODataRoutePrefix("odata/conData/DeviceCodes")]
  [Route("mvc/odata/conData/DeviceCodes")]
  public partial class DeviceCodesController : ODataController
  {
    private Data.ConDataContext context;

    public DeviceCodesController(Data.ConDataContext context)
    {
      this.context = context;
    }
    // GET /odata/ConData/DeviceCodes
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.ConData.DeviceCode> GetDeviceCodes()
    {
      var items = this.context.DeviceCodes.AsQueryable<Models.ConData.DeviceCode>();
      this.OnDeviceCodesRead(ref items);

      return items;
    }

    partial void OnDeviceCodesRead(ref IQueryable<Models.ConData.DeviceCode> items);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{UserCode}")]
    public SingleResult<DeviceCode> GetDeviceCode(string key)
    {
        var items = this.context.DeviceCodes.Where(i=>i.UserCode == key);
        return SingleResult.Create(items);
    }
    partial void OnDeviceCodeDeleted(Models.ConData.DeviceCode item);
    partial void OnAfterDeviceCodeDeleted(Models.ConData.DeviceCode item);

    [HttpDelete("{UserCode}")]
    public IActionResult DeleteDeviceCode(string key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.DeviceCodes
                .Where(i => i.UserCode == key)
                .FirstOrDefault();

            if (item == null)
            {
                return BadRequest();
            }

            this.OnDeviceCodeDeleted(item);
            this.context.DeviceCodes.Remove(item);
            this.context.SaveChanges();
            this.OnAfterDeviceCodeDeleted(item);

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnDeviceCodeUpdated(Models.ConData.DeviceCode item);
    partial void OnAfterDeviceCodeUpdated(Models.ConData.DeviceCode item);

    [HttpPut("{UserCode}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutDeviceCode(string key, [FromBody]Models.ConData.DeviceCode newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (newItem == null || (newItem.UserCode != key))
            {
                return BadRequest();
            }

            this.OnDeviceCodeUpdated(newItem);
            this.context.DeviceCodes.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.DeviceCodes.Where(i => i.UserCode == key);
            this.OnAfterDeviceCodeUpdated(newItem);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    [HttpPatch("{UserCode}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PatchDeviceCode(string key, [FromBody]Delta<Models.ConData.DeviceCode> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.DeviceCodes.Where(i => i.UserCode == key).FirstOrDefault();

            if (item == null)
            {
                return BadRequest();
            }

            patch.Patch(item);

            this.OnDeviceCodeUpdated(item);
            this.context.DeviceCodes.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.DeviceCodes.Where(i => i.UserCode == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnDeviceCodeCreated(Models.ConData.DeviceCode item);
    partial void OnAfterDeviceCodeCreated(Models.ConData.DeviceCode item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.ConData.DeviceCode item)
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

            this.OnDeviceCodeCreated(item);
            this.context.DeviceCodes.Add(item);
            this.context.SaveChanges();

            return Created($"odata/ConData/DeviceCodes/{item.UserCode}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
