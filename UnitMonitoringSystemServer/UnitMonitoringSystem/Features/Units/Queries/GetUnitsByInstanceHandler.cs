using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UnitMonitoringSystem.Api.ViewModels;
using UnitMonitoringSystem.Core.Interfaces;

namespace UnitMonitoringSystem.Api.Features.Units.Queries
{
    public class GetUnitsByInstanceHandler : IRequestHandler<GetUnitsByInstance, IEnumerable<UnitViewModel>>
    {
        private readonly IUnitRepository unitRepository;
        private readonly IMapper mapper;

        public GetUnitsByInstanceHandler(IUnitRepository unitRepository, IMapper mapper)
        {
            this.unitRepository = unitRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<UnitViewModel>> Handle(GetUnitsByInstance request, CancellationToken cancellationToken)
        {
            var units = await unitRepository.GetUnitsByInstanceId(request.InstanceId);
            return mapper.Map<IEnumerable<UnitViewModel>>(units);
        }
    }
}
