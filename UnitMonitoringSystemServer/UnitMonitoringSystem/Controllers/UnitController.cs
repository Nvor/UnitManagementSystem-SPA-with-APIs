using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitMonitoringSystem.Api.Features.Units.Commands;
using UnitMonitoringSystem.Api.Features.Units.Queries;
using UnitMonitoringSystem.Api.ViewModels;

namespace UnitMonitoringSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        private readonly IMediator mediator;

        public UnitController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("{instanceId}")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> Get(int instanceId)
        {
            var units = await mediator.Send(new GetUnitsByInstance(instanceId));
            return Ok(units);
        }

        [HttpPost]
        [ProducesResponseType(201)]
        public async Task<IActionResult> Post([FromBody] UnitViewModel unit)
        {
            var newUnit = await mediator.Send(new AddUnit(unit));
            return Created("/api/unit/{newUnit.ID}", newUnit);
        }

        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Put([FromBody] UnitViewModel unit)
        {
            var response = await mediator.Send(new UpdateUnit(unit));
            if (response.HasError)
            {
                return NotFound(response.Data);
            }

            return Ok(response.Data);
        }

        [HttpDelete]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Delete([FromBody] UnitViewModel unit)
        {
            var response = await mediator.Send(new DeleteUnit(unit));
            if (response.HasError)
            {
                return NotFound(response.Data);
            }

            return Ok(response.Data);
        }
    }
}
