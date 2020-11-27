using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitMonitoringSystem.Api.ViewModels;

namespace UnitMonitoringSystem.Api.Features.Units.Queries
{
    public class GetUnitsByInstance : IRequest<IEnumerable<UnitViewModel>>
    {
        public int InstanceId { get; set; }

        public GetUnitsByInstance(int instanceId)
        {
            InstanceId = instanceId;
        }
    }
}
