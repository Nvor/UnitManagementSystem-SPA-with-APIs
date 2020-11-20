using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitMonitoringSystem.Api.ViewModels;
using UnitMonitoringSystem.Core.Entities;

namespace UnitMonitoringSystem.Api.Mappings
{
    public class DefaultMapperProfile : Profile
    {
        public DefaultMapperProfile()
        {
            CreateMap<Instance, InstanceViewModel>();
            CreateMap<Unit, UnitViewModel>();
        }
    }
}
