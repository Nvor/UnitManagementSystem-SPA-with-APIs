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

        // Remove later - Units should only be pulled by user/instance/unit id
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var units = await mediator.Send(new GetUnits());
            return Ok(units);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UnitViewModel unit)
        {
            var newUnit = await mediator.Send(new AddUnit(unit));
            return Created("/api/unit/{newUnit.ID}", newUnit);
        }

        [HttpPut]
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
