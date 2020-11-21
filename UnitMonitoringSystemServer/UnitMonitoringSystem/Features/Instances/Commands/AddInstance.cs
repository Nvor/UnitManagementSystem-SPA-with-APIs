using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitMonitoringSystem.Api.ViewModels;

namespace UnitMonitoringSystem.Api.Features.Instances.Commands
{
    public class AddInstance : IRequest<InstanceViewModel>
    {
        public InstanceViewModel instance;

        public AddInstance(InstanceViewModel instance)
        {
            this.instance = instance;
        }
    }
}
