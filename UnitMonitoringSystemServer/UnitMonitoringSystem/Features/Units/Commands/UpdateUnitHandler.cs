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
    public class UpdateUnitHandler : IRequestHandler<UpdateUnit, Response>
    {
        private readonly IUnitRepository unitRepository;
        private readonly IMapper mapper;

        public UpdateUnitHandler(IUnitRepository unitRepository, IMapper mapper)
        {
            this.unitRepository = unitRepository;
            this.mapper = mapper;
        }

        public async Task<Response> Handle(UpdateUnit request, CancellationToken cancellationToken)
        {
            var unit = mapper.Map<Core.Entities.Unit>(request.unit);

            await unitRepository.UpdateAsync(unit);
            return new Response(unit);
        }
    }
}
