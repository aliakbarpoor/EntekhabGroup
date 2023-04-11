using API.Services;
using Domain.Interface;
using Domain.Services;
using Infrustracture.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;


namespace API.Extentions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
        {

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            //services.AddScoped(typeof(IOvetimePolicyService),typeof( OvetimePolicyService));

            services.AddScoped<ISalaryService, SalaryService>();
            services.AddScoped(typeof(IAsyncRepository<>), typeof(Repository<>));
            services.AddScoped<IOvertimePolicyService, OvetimePolicyService>();

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Entekhab Group API",
                    Description = "EntekhabGroup Task",

                });
            
            });

            return services;


        }
    }
}
