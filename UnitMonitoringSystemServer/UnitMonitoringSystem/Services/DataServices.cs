using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitMonitoringSystem.Core.Interfaces;
using UnitMonitoringSystem.Infrastructure.Data.Repositories;

namespace UnitMonitoringSystem.Api.Configurations
{
    public static class DataServices
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IInstanceRepository, InstanceRepository>();
            services.AddScoped<IUnitRepository, UnitRepository>();

            return services;
        }
    }
}
