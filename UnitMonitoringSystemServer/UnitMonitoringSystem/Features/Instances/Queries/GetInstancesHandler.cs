using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UnitMonitoringSystem.Core.Interfaces;
using UnitMonitoringSystem.Api.ViewModels;
using AutoMapper;

namespace UnitMonitoringSystem.Api.Features.Instances.Queries
{
    public class GetInstancesHandler : IRequestHandler<GetInstances, IEnumerable<InstanceViewModel>>
    {
        private readonly IInstanceRepository instanceRepository;
        private readonly IMapper mapper;

        public GetInstancesHandler(IInstanceRepository instanceRepository, IMapper mapper)
        {
            this.instanceRepository = instanceRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<InstanceViewModel>> Handle(GetInstances request, CancellationToken cancellationToken)
        {
            var instances = await instanceRepository.GetAllListAsync();
            return mapper.Map<IEnumerable<InstanceViewModel>>(instances);
        }
    }
}
