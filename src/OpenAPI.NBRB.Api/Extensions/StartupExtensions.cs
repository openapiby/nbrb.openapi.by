using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace OpenAPI.NBRB.Api.Extensions
{
    public static class StartupExtensions
    {
        public static void AddSwagger(this IServiceCollection services)
        {
            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "The Open NBRB API",
                    Description = "The Open API that allows users to obtain existing information of banks",
                    TermsOfService = new Uri("https://openapi.by/terms"),
                    Contact = new OpenApiContact
                    {
                        Name = "OpenAPI",
                        Email = "info@openapi.by",
                        Url = new Uri("https://openapi.by")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Apache 2.0",
                        Url = new Uri("http://www.apache.org/licenses/LICENSE-2.0.html")
                    }
                });
                c.EnableAnnotations();
            });
        }
    }
}
