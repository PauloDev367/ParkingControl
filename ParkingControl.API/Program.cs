using ParkingControl.Application;
using ParkingControl.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureApplicationDbContext(builder.Configuration);
builder.Services.ConfigureSwagger();
builder.Services.AddEndpointsApiExplorer();


builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssembly(typeof(AssemblyReference).Assembly)
);

builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Parking Control API V1");
    });
}

app.MapGet("/api/v1", () => { Results.Ok("API is running"); });

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();