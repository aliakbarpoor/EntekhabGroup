using API.Extentions;
using API.Formatters;
using API.Services;
using Domain;
using Infrustracture;
using Microsoft.EntityFrameworkCore;

using Microsoft.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddDbContext<EFContext>(options =>
                            options.UseSqlServer(builder.Configuration.GetConnectionString("AppConnectionString")));

       
        builder.Services.ConfigureApplicationServices();




        builder.Services.AddControllers(opt =>
        {
            opt.OutputFormatters.Insert(0, new CustomOutputFormatter());
            opt.InputFormatters.Insert(0, new CustomInputFormatter());
            opt.FormatterMappings.SetMediaTypeMappingForFormat("custom", MediaTypeHeaderValue.Parse("text/custom"));

        })
            .AddXmlSerializerFormatters();


        var app = builder.Build();

        // Configure the HTTP request pipeline.


        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseAuthorization();

        app.MapControllers();



        app.Run();
    }
}