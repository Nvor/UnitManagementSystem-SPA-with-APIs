using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitMonitoringSystem.Api.Features.Units.Queries;

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
    }
}
