using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UnitMonitoringSystem.Core.Entities;
using UnitMonitoringSystem.Core.Interfaces;

namespace UnitMonitoringSystem.Api.Features.Instances.Commands
{
    public class UpdateInstanceHandler : IRequestHandler<UpdateInstance, Response>
    {
        private readonly IInstanceRepository instanceRepository;
        private readonly IMapper mapper;

        public UpdateInstanceHandler(IInstanceRepository instanceRepository, IMapper mapper)
        {
            this.instanceRepository = instanceRepository;
            this.mapper = mapper;
        }

        public async Task<Response> Handle(UpdateInstance request, CancellationToken cancellationToken)
        {
            var instance = mapper.Map<Instance>(request.instance);

            await instanceRepository.UpdateAsync(instance);
            return new Response(instance);
        }
    }
}
