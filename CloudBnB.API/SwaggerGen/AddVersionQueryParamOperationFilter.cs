using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace CloudBnB.API.SwaggerGen
{
    /// <summary>
    /// Adds ?api-version=2.0 to any controller annotated with the v2 groupname.
    /// Worked together with Jasper for this.
    /// </summary>
    public class AddVersionQueryParamOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var groupName = context.ApiDescription.GroupName;

            if (groupName != "v2")
                return;

            if (operation.Parameters.Any(parameter => parameter.Name == "api-verison"))
                return;

            operation.Parameters ??= [];
            operation.Parameters.Add(new OpenApiParameter
            {
                Name = "api-version",
                In = ParameterLocation.Query,
                Required = true,
                Description = "API version. Keep it at 2.0",
                Schema = new OpenApiSchema { Type = "string" },
                Example = new OpenApiString("2.0")
            });
        }
    }
}
