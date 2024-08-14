using Application.Services;
using Domain.Entities;
using Domain.IServices;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {
            services.AddScoped<TEMPLATE_ENTITY_SERVICE_INTERFACE<TEMPLATE_ENTITY_CLASS>, TEMPLATE_ENTITY_SERVICE_INTERFACE_DECLARATION>();
            return services;
        }
    }
}
