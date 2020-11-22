using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitMonitoringSystem.Api.Features.Instances.Commands;
using UnitMonitoringSystem.Api.Features.Instances.Queries;
using UnitMonitoringSystem.Api.ViewModels;

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
        [ProducesResponseType(200)]
        public async Task<IActionResult> Get()
        {
            var instances = await mediator.Send(new GetInstances(0));
            return Ok(instances);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> GetByIdWithUnits(int id)
        {
            return Ok();
        }

        [HttpPost]
        [ProducesResponseType(201)]
        public async Task<IActionResult> Post([FromBody] InstanceViewModel instance)
        {
            var newInstance = await mediator.Send(new AddInstance(instance));
            return Created("/api/instance/{newInstance.ID}", newInstance);
        }

        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Put([FromBody] InstanceViewModel instance)
        {
            var response = await mediator.Send(new UpdateInstance(instance));
            if (response.HasError)
            {
                return NotFound();
            }

            return Ok();
        }

        [HttpDelete]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Delete([FromBody] InstanceViewModel instance)
        {
            var response = await mediator.Send(new DeleteInstance(instance));
            if (response.HasError)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
