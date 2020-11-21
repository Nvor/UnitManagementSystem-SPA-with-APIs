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

namespace UnitMonitoringSystem.Api.Features.Instances.Commands
{
    public class AddInstanceHandler : IRequestHandler<AddInstance, InstanceViewModel>
    {
        private readonly IInstanceRepository instanceRepository;
        private readonly IMapper mapper;
        public AddInstanceHandler(IInstanceRepository instanceRepository, IMapper mapper)
        {
            this.instanceRepository = instanceRepository;
            this.mapper = mapper;
        }

        public async Task<InstanceViewModel> Handle(AddInstance request, CancellationToken cancellationToken)
        {
            var instance = await instanceRepository.AddAsync(mapper.Map<Instance>(request.instance));
            return mapper.Map<InstanceViewModel>(instance);
        }
    }
}
