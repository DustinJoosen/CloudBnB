using CloudBnB.API.SwaggerGen;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using System.Reflection;

namespace CloudBnB.API.SwaggerGen
{
    /// <summary>
    /// Add all swagger information
    /// </summary>
    public static class SwaggerGenConfig
    {
        public static IServiceCollection AddSwaggerGeneration(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.ResolveConflictingActions(apiDesc => apiDesc.First());
                options.OperationFilter<AddVersionQueryParamOperationFilter>();

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

            return services;
        }
    }
}
