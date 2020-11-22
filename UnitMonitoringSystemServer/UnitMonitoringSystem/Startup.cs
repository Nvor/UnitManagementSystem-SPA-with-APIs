using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using UnitMonitoringSystem.Infrastructure.Data;
using MediatR;
using AutoMapper;
using UnitMonitoringSystem.Api.Features.Instances.Queries;
using UnitMonitoringSystem.Core.Interfaces;
using UnitMonitoringSystem.Infrastructure.Data.Repositories;
using Microsoft.OpenApi.Models;

namespace UnitMonitoringSystem.Api
{
    public class Startup
    {
        readonly string CorsPolicy = "CorsPolicy";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IInstanceRepository, InstanceRepository>();
            services.AddScoped<IUnitRepository, UnitRepository>();

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("UnitManagementSystemDatabase")));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { 
                    Title = "UnitMonitoringSystem", 
                    Version = "v1",
                    Description = "API for accessing Unit Management System data"});
            });

            services.AddControllers();

            services.AddAutoMapper(GetType().Assembly);
            services.AddMediatR(typeof(GetInstancesHandler).Assembly);

            services.AddCors(options =>
            {
                options.AddPolicy(name: CorsPolicy,
                    builder => builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        //.AllowCredentials()
                        );
            });

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "UMS API V1");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(CorsPolicy);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
