using Domain.Interface;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;

namespace Domain
{
    public static class ApplicationServicesRegistration
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
        {

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            //services.AddScoped(typeof(IOvetimePolicyService),typeof( OvetimePolicyService));

            services.AddScoped<IOvertimePolicyService, OvetimePolicyService>();

            return services;


        }
    }
}
