using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitMonitoringSystem.Api.ViewModels;

namespace UnitMonitoringSystem.Api.Features.Units.Queries
{
    public class GetUnits : IRequest<IEnumerable<UnitViewModel>>
    {
        
    }
}
