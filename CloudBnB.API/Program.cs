/*
 * Dustin Joosen
 * S1184503@student.windesheim.nl
 * WFHBOICT.CSharp2.22
 */

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CloudBnB.API.Data;
using CloudBnB.API.Services.Repositories;
using CloudBnB.API.Services;
using CloudBnB.API.Models;
using CloudBnB.API.Services.Interfaces;
using System.Text.Json.Serialization;
using Microsoft.OpenApi.Models;
using Asp.Versioning;
using System.Reflection;
using CloudBnB.API.SwaggerGen;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CloudBnBDbConn")));

// Repositories.
builder.Services.AddScoped<ILocationRepository, LocationRepository>();
builder.Services.AddScoped<ILandlordRepository, LandlordRepository>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IReservationRepository, ReservationRepository>();
builder.Services.AddScoped<IImageRepository, ImageRepository>();

// Services.
builder.Services.AddScoped<ISearchService, SearchService>();
builder.Services.AddScoped<IImageService, ImgurService>();
builder.Services.AddScoped<IReservationService, ReservationService>();

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddApiVersioning(options => 
{
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.ReportApiVersions = true;
    options.ApiVersionReader = new QueryStringApiVersionReader("api-version");
}).AddMvc();

builder.Services.AddControllers(options =>
{
    options.Conventions.Add(new ApiVersionBasedGroupingConvention());
})
    .AddJsonOptions(opt =>
    {
        opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGeneration();

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("AllowWebApp", builder =>
    {
        builder.WithOrigins("https://cloudbnb-df3c1.web.app")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(config =>
    {
        config.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1");
        config.SwaggerEndpoint("/swagger/v2/swagger.json", "API v2");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("AllowWebApp");

app.MapControllers();

app.Run();
