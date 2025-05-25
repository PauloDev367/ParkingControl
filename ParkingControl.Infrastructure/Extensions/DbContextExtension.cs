using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ParkingControl.Infrastructure.Persistence;

namespace ParkingControl.Infrastructure.Extensions;

public static class DbContextExtension
{
    public static void ConfigureApplicationDbContext(this IServiceCollection service, IConfiguration configuration)
    {
        var connString = configuration.GetConnectionString("SqlServer")
            ?? throw new InvalidOperationException("Db context was not configurated");
     
        service.AddDbContext<ParkingDbContext>(conf =>
        {
            conf.UseSqlServer(connString);
        });
    }
}
