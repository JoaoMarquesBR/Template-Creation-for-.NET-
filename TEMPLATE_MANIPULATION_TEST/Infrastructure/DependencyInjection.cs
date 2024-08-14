using Domain.Entities;
using Domain.IRepo;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepositoryDependencies(this IServiceCollection services)
        {
            services.AddScoped<TEMPLATE_ENTITY_REPOSITORY_INTERFACE<TEMPLATE_ENTITY_CLASS>, TEMPLATE_REPOSITORY_INTERFACE_IMPLEMENTATION>();
            return services;
        }
    }
}
