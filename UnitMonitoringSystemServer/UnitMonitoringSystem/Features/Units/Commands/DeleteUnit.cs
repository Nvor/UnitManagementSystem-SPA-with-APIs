using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitMonitoringSystem.Api.ViewModels;

namespace UnitMonitoringSystem.Api.Features.Units.Commands
{
    public class DeleteUnit : IRequest<Response>
    {
        public UnitViewModel unit;

        public DeleteUnit(UnitViewModel unit)
        {
            this.unit = unit;
        }
    }
}
