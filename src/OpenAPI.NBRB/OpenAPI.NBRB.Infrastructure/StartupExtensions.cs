using System;
using Microsoft.Extensions.DependencyInjection;
using OpenAPI.NBRB.Domain.Contracts;
using OpenAPI.NBRB.Domain.Services;

namespace OpenAPI.NBRB.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static void AppDomainServices(this IServiceCollection services)
        {
            services.AddScoped<IBankService, BankService>();
        }

        //public static void ConfigureAutoMapper(this IServiceCollection services)
        //{
        //    services.AddAutoMapper(typeof(ServiceCollectionExtensions).Assembly);
        //}
    }
}
