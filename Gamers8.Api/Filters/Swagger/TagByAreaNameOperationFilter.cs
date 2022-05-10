using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Gamers8.Api.Filters.Swagger
{
    public class TagByAreaNameOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (context.ApiDescription.ActionDescriptor is ControllerActionDescriptor controllerActionDescriptor)
            {
                var areaName = controllerActionDescriptor.ControllerTypeInfo.GetCustomAttributes(typeof(AreaAttribute), true)
                    .Cast<AreaAttribute>().FirstOrDefault();
                if (areaName != null)
                {
                    operation.Tags = new List<OpenApiTag> { new OpenApiTag { Name = areaName.RouteValue } };
                }
                else
                {
                    operation.Tags = new List<OpenApiTag> { new OpenApiTag { Name = "Without Area (old apis)" } };
                }
            }
        }
    }
}