using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitMonitoringSystem.Api.ViewModels;

namespace UnitMonitoringSystem.Api.Features.Instances.Queries
{
    public class GetInstances : IRequest<IEnumerable<InstanceViewModel>>
    {
        public int UserId { get; set; }

        public GetInstances(int userId)
        {
            UserId = userId;
        }
    }
}
