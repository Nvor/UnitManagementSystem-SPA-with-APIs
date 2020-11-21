using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UnitMonitoringSystem.Core.Interfaces;

namespace UnitMonitoringSystem.Api.Features.Units.Commands
{
    public class DeleteUnitHandler : IRequestHandler<DeleteUnit, Response>
    {
        private readonly IUnitRepository unitRepository;
        private readonly IMapper mapper;

        public DeleteUnitHandler(IUnitRepository unitRepository, IMapper mapper)
        {
            this.unitRepository = unitRepository;
            this.mapper = mapper;
        }

        public async Task<Response> Handle(DeleteUnit request, CancellationToken cancellationToken)
        {
            var unit = await unitRepository.GetByIdAsync(request.unit.ID);
            if (unit == null)
            {
                return new Response("Unit does not exist", true);
            }

            await unitRepository.DeleteAsync(unit);
            return new Response(unit);
        }
    }
}
