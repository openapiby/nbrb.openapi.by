using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using OpenAPI.NBRB.Common.Filters;
using OpenAPI.NBRB.Data.Contracts;
using OpenAPI.NBRB.Data.InMemory;
using OpenAPI.NBRB.Domain.Contracts;
using OpenAPI.NBRB.Domain.Services;

namespace OpenAPI.NBRB.Infrastructure
{
    public static class StartupExtensions
    {
        public static void AddAppDomainServices(this IServiceCollection services)
        {
            services.AddScoped<IBankService, BankService>();
        }

        public static void AddAppDataRepositories(this IServiceCollection services)
        {
            services.AddSingleton<IBankRepository, InMemoryBankRepository>();
        }

        public static IMvcCoreBuilder ConfigureMvcCore(this IServiceCollection services)
        {
            return services.AddMvcCore()
                .AddMvcOptions(options =>
                {
                    options.Filters.Add(typeof(ErrorActionFilter));
                    options.Filters.Add(typeof(LoggingActionFilter));
                });
        }

        public static void ConfigureAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(StartupExtensions).Assembly);
        }
    }
}
