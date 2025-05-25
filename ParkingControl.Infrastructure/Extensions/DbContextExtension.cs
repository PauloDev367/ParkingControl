using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ParkingControl.Infrastructure.Persistence;

namespace ParkingControl.Infrastructure.Extensions;

public static class DbContextExtension
{
    public static IServiceCollection ConfigureApplicationDbContext(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        var connString = configuration.GetConnectionString("SqlServer")
            ?? throw new InvalidOperationException("Db context was not configurated");

        services.AddDbContext<ParkingDbContext>(options =>
        {
            options.UseSqlServer(connString, sql =>
            {
                sql.MigrationsAssembly(typeof(ParkingDbContext).Assembly.FullName);
            });
        });

        return services;
    }
}
