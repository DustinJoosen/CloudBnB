using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CloudBnB.API.Data;
using CloudBnB.API.Services.Repositories;
using CloudBnB.API.Services;
using CloudBnB.API.Models;
using CloudBnB.API.Services.Interfaces;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CloudBnBDbConn")));

// Repositories.
builder.Services.AddScoped<ILocationRepository, LocationRepository>();
builder.Services.AddScoped<ILandlordRepository, LandlordRepository>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IImageRepository, ImageRepository>();

// Services.
builder.Services.AddScoped<ISearchService, SearchService>();
builder.Services.AddScoped<IImageService, ImgurService>();

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddControllers()
    .AddJsonOptions(opt =>
    {
        opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("AllowWebApp");

app.MapControllers();

app.Run();
