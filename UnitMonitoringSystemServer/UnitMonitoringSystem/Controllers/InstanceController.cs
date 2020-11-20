using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitMonitoringSystem.Api.Features.Instances.Queries;

namespace UnitMonitoringSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstanceController : ControllerBase
    {
        private readonly IMediator mediator;

        public InstanceController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var instances = await mediator.Send(new GetInstances(0));
            return Ok(instances);
        }
    }
}
