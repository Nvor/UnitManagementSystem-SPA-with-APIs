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
    public class InstanceController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Instance> Get()
        {
            //return Instance.GetTestInstanceData();
            return Instance.GetAllTestInstanceData();
        }

        [HttpGet("{id}", Name = "GetInstance")]
        public Instance Get(int id)
        {
            return Instance.GetTestInstanceData().FirstOrDefault((i) => i.Id == id);
        }

        // GET: api/Instance/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Instance
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Instance/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
