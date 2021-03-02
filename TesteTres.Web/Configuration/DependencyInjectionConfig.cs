using Microsoft.Extensions.DependencyInjection;
using TesteTres.Web.Services;

namespace TesteTres.Web.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            //Registrar as dependências
            services.AddHttpClient<ICandidatoService, CandidatoService>();
            services.AddHttpClient<IRepositorioService, RepositorioService>();
        }
    }
}
