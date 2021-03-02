using Microsoft.Extensions.DependencyInjection;
using TesteTres.Domain.Interface.Service;
using TesteTres.Service;

namespace TesteTres.Infrastructure.CrossCutting.InversionOfControl
{
    public static class ServiceDependency
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {
            services.AddScoped<IRepositorioService, RepositorioService>();
        }
    }
}
