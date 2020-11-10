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

  [ODataRoutePrefix("odata/conData/PersistedGrants")]
  [Route("mvc/odata/conData/PersistedGrants")]
  public partial class PersistedGrantsController : ODataController
  {
    private Data.ConDataContext context;

    public PersistedGrantsController(Data.ConDataContext context)
    {
      this.context = context;
    }
    // GET /odata/ConData/PersistedGrants
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.ConData.PersistedGrant> GetPersistedGrants()
    {
      var items = this.context.PersistedGrants.AsQueryable<Models.ConData.PersistedGrant>();
      this.OnPersistedGrantsRead(ref items);

      return items;
    }

    partial void OnPersistedGrantsRead(ref IQueryable<Models.ConData.PersistedGrant> items);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{Key}")]
    public SingleResult<PersistedGrant> GetPersistedGrant(string key)
    {
        var items = this.context.PersistedGrants.Where(i=>i.Key == key);
        return SingleResult.Create(items);
    }
    partial void OnPersistedGrantDeleted(Models.ConData.PersistedGrant item);
    partial void OnAfterPersistedGrantDeleted(Models.ConData.PersistedGrant item);

    [HttpDelete("{Key}")]
    public IActionResult DeletePersistedGrant(string key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.PersistedGrants
                .Where(i => i.Key == key)
                .FirstOrDefault();

            if (item == null)
            {
                return BadRequest();
            }

            this.OnPersistedGrantDeleted(item);
            this.context.PersistedGrants.Remove(item);
            this.context.SaveChanges();
            this.OnAfterPersistedGrantDeleted(item);

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnPersistedGrantUpdated(Models.ConData.PersistedGrant item);
    partial void OnAfterPersistedGrantUpdated(Models.ConData.PersistedGrant item);

    [HttpPut("{Key}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutPersistedGrant(string key, [FromBody]Models.ConData.PersistedGrant newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (newItem == null || (newItem.Key != key))
            {
                return BadRequest();
            }

            this.OnPersistedGrantUpdated(newItem);
            this.context.PersistedGrants.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.PersistedGrants.Where(i => i.Key == key);
            this.OnAfterPersistedGrantUpdated(newItem);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    [HttpPatch("{Key}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PatchPersistedGrant(string key, [FromBody]Delta<Models.ConData.PersistedGrant> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.PersistedGrants.Where(i => i.Key == key).FirstOrDefault();

            if (item == null)
            {
                return BadRequest();
            }

            patch.Patch(item);

            this.OnPersistedGrantUpdated(item);
            this.context.PersistedGrants.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.PersistedGrants.Where(i => i.Key == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnPersistedGrantCreated(Models.ConData.PersistedGrant item);
    partial void OnAfterPersistedGrantCreated(Models.ConData.PersistedGrant item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.ConData.PersistedGrant item)
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

            this.OnPersistedGrantCreated(item);
            this.context.PersistedGrants.Add(item);
            this.context.SaveChanges();

            return Created($"odata/ConData/PersistedGrants/{item.Key}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
