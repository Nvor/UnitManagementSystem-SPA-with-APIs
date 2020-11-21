using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitMonitoringSystem.Api.ViewModels;

namespace UnitMonitoringSystem.Api.Features.Instances.Commands
{
    public class DeleteInstance : IRequest<Response>
    {
        public InstanceViewModel instance;

        public DeleteInstance(InstanceViewModel instance)
        {
            this.instance = instance;
        }
    }
}
