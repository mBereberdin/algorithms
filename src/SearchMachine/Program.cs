using System.Reflection;

using Microsoft.OpenApi.Models;

using SearchMachine.Services.Implementations;
using SearchMachine.Services.Interfaces;

// Настройка сервисов приложения.
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Algorithms example api",
        Description = "ASP.NET Core Web API для проверки работы алгоритмов."
    });

    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

builder.Services.AddControllers();

// Настройка приложения.
var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(options => { options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1"); });

app.MapControllers();

app.Run();