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

  [ODataRoutePrefix("odata/conData/Countries")]
  [Route("mvc/odata/conData/Countries")]
  public partial class CountriesController : ODataController
  {
    private Data.ConDataContext context;

    public CountriesController(Data.ConDataContext context)
    {
      this.context = context;
    }
    // GET /odata/ConData/Countries
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.ConData.Country> GetCountries()
    {
      var items = this.context.Countries.AsQueryable<Models.ConData.Country>();
      this.OnCountriesRead(ref items);

      return items;
    }

    partial void OnCountriesRead(ref IQueryable<Models.ConData.Country> items);

    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{CountryID}")]
    public SingleResult<Country> GetCountry(int key)
    {
        var items = this.context.Countries.Where(i=>i.CountryID == key);
        return SingleResult.Create(items);
    }
    partial void OnCountryDeleted(Models.ConData.Country item);
    partial void OnAfterCountryDeleted(Models.ConData.Country item);

    [HttpDelete("{CountryID}")]
    public IActionResult DeleteCountry(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Countries
                .Where(i => i.CountryID == key)
                .Include(i => i.Students)
                .Include(i => i.Students1)
                .Include(i => i.Students2)
                .Include(i => i.Students3)
                .FirstOrDefault();

            if (item == null)
            {
                return BadRequest();
            }

            this.OnCountryDeleted(item);
            this.context.Countries.Remove(item);
            this.context.SaveChanges();
            this.OnAfterCountryDeleted(item);

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnCountryUpdated(Models.ConData.Country item);
    partial void OnAfterCountryUpdated(Models.ConData.Country item);

    [HttpPut("{CountryID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutCountry(int key, [FromBody]Models.ConData.Country newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (newItem == null || (newItem.CountryID != key))
            {
                return BadRequest();
            }

            this.OnCountryUpdated(newItem);
            this.context.Countries.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Countries.Where(i => i.CountryID == key);
            this.OnAfterCountryUpdated(newItem);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    [HttpPatch("{CountryID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult PatchCountry(int key, [FromBody]Delta<Models.ConData.Country> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Countries.Where(i => i.CountryID == key).FirstOrDefault();

            if (item == null)
            {
                return BadRequest();
            }

            patch.Patch(item);

            this.OnCountryUpdated(item);
            this.context.Countries.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Countries.Where(i => i.CountryID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnCountryCreated(Models.ConData.Country item);
    partial void OnAfterCountryCreated(Models.ConData.Country item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxAnyAllExpressionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.ConData.Country item)
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

            this.OnCountryCreated(item);
            this.context.Countries.Add(item);
            this.context.SaveChanges();

            return Created($"odata/ConData/Countries/{item.CountryID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
