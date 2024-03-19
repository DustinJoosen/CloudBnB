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

builder.Services.AddApiVersioning(options => 
{
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.ApiVersionReader = new QueryStringApiVersionReader("api-version");
}).AddMvc();

builder.Services.AddControllers()
    .AddJsonOptions(opt =>
    {
        opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.ResolveConflictingActions(apiDesc => apiDesc.First());
    options.SwaggerDoc("v1", new OpenApiInfo 
    { 
        Title = "API V1", 
        Version = "V1",
        Description = "An API to manage CloudBnB",
        Contact = new OpenApiContact
        {
            Name = "User interface",
            Url = new Uri("https://cloudbnb-df3c1.web.app/")
        }
    });

    options.SwaggerDoc("v2", new OpenApiInfo
    {
        Title = "API V2",
        Version = "V2",
        Description = "An API to manage CloudBnB",
        Contact = new OpenApiContact
        {
            Name = "User interface",
            Url = new Uri("https://cloudbnb-df3c1.web.app/")
        }
    });

    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

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
