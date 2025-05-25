using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace ParkingControl.Infrastructure.Extensions;

public static class SwaggerExtension
{
   public static IServiceCollection ConfigureSwagger(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();  // 🔥 Este é OBRIGATÓRIO
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Parking Control API",
                Version = "v1",
                Description = "API for Parking Management System"
            });
        });

        return services;
    }
}
