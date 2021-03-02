using Microsoft.Extensions.DependencyInjection;
using TesteTres.Domain.Interface.Repository;
using TesteTres.Infrastructure.Data.Repository;

namespace TesteTres.Infrastructure.CrossCutting.InversionOfControl
{
    public static class RepositoryDependency
    {
        public static void AddRepositoryDependency(this IServiceCollection services)
        {
            services.AddScoped<IRepositorioRepository, RepositorioRepository>();
        }
    }
}
