using Domain;
using Infrustracture;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<EFContext>(options =>
                    options.UseSqlServer(builder.Configuration.GetConnectionString("AppConnectionString")));


ApplicationServicesRegistration.ConfigureApplicationServices(builder.Services);

builder.Services.AddControllers();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
