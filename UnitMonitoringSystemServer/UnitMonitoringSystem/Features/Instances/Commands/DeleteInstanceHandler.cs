using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UnitMonitoringSystem.Core.Interfaces;

namespace UnitMonitoringSystem.Api.Features.Instances.Commands
{
    public class DeleteInstanceHandler : IRequestHandler<DeleteInstance, Response>
    {
        private readonly IInstanceRepository instanceRepository;
        private readonly IMapper mapper;

        public DeleteInstanceHandler(IInstanceRepository instanceRepository, IMapper mapper)
        {
            this.instanceRepository = instanceRepository;
            this.mapper = mapper;
        }

        public async Task<Response> Handle(DeleteInstance request, CancellationToken cancellationToken)
        {
            var instance = instanceRepository.GetByIdAsync(request.instance.ID);
            if (instance == null)
            {
                return new Response("Instance does not exist", true);
            }

            await instanceRepository.DeleteAsync(instance.Result);
            return new Response(instance);
        }
    }
}
