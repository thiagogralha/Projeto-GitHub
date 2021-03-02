using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TesteTres.Infrastructure.Core.GitHub;
using TesteTres.Infrastructure.CrossCutting.GitHub;

namespace TesteTres.Infrastructure.CrossCutting.InversionOfControl
{
    public static class InfrastructureDependency
    {
        public static void AddInfrastructureDependency(this IServiceCollection services)
        {
            #region GitHub
                       
            services.AddScoped<IGitHubService, GitHubService>();
            services.AddScoped<GitHub.GitHub>();

            #endregion

        }

    }
}
