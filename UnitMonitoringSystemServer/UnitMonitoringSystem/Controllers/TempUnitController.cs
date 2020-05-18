using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitMonitoringSystem.Models;

namespace UnitMonitoringSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TempUnitController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Unit> Get()
        {
            return Unit.GetTestListOfTempUnits();
        }

        [HttpGet("{id}", Name = "GetUnit")]
        public Unit Get(int id)
        {
            return Unit.GetTestListOfTempUnits().FirstOrDefault((t) => t.UnitId == id);
        }

        // GET: api/TempUnit/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/TempUnit
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        // PUT: api/TempUnit/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
