using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UnitMonitoringSystem.Api.ViewModels;
using UnitMonitoringSystem.Core.Entities;
using UnitMonitoringSystem.Core.Interfaces;

namespace UnitMonitoringSystem.Api.Features.Units.Queries
{
    public class AddUnitHandler : IRequestHandler<AddUnit, UnitViewModel>
    {
        private readonly IUnitRepository unitRepository;
        private readonly IMapper mapper;

        public AddUnitHandler(IUnitRepository unitRepository, IMapper mapper)
        {
            this.unitRepository = unitRepository;
            this.mapper = mapper;
        }

        public async Task<UnitViewModel> Handle(AddUnit request, CancellationToken cancellationToken)
        {
            var unit = await unitRepository.AddAsync(mapper.Map<Core.Entities.Unit>(request.unit));
            return mapper.Map<UnitViewModel>(unit);
        }
    }
}
