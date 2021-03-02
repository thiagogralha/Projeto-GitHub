using System;
using System.Collections.Generic;
using TesteTres.Infrastructure.Core.GitHub;

namespace TesteTres.Infrastructure.CrossCutting.GitHub
{
    public class GitHubService : IGitHubService
    {
        private readonly GitHub _gitHub;

        public GitHubService(GitHub gitHub)
        {
            _gitHub = gitHub;
        }

        public List<RepositorioGitHubResponse> ListarRepositorios(string username)
        {
            var result = _gitHub.ListarRepositorios(username);

            var repositorio = result.ConvertAll(x => new RepositorioGitHubResponse
            {
                Name = x.name,
                Description = x.description,
                Language = x.language,
                Owner = new Core.GitHub.Owner
                {
                    Login = x.owner.login,
                },
                Updated_at = x.updated_at,
            });

            return repositorio;
        }

        public RepositorioGitHubResponse DetalhesDoRepositorio(string username, string nomeRepositorio)
        {
            var repositorio = _gitHub.DetalhesDoRepositorio(username, nomeRepositorio);

            if (repositorio == null)
                return new RepositorioGitHubResponse();

            return new RepositorioGitHubResponse
            {
                Name = repositorio.name,
                Description = repositorio.description,
                Language = repositorio.language,
                Owner = new Core.GitHub.Owner
                {
                    Login = repositorio.owner.login,
                },
                Updated_at = repositorio.updated_at,
            };
        }

        public RepositorioPesquisaGitHubResponse PesquisarRepositorios(string nomeRepositorio)
        {
            var result = _gitHub.PesquisarRepositorios(nomeRepositorio);

            if (result == null)
                return new RepositorioPesquisaGitHubResponse();

            return new RepositorioPesquisaGitHubResponse
            {
                Total_count = result.total_count,
                Items = result.items.ConvertAll(x => new Core.GitHub.ItemsPesquisa
                {
                    Description = x.description,
                    Language = x.language,
                    Name = x.name,
                    Owner = new Core.GitHub.OwnerPesquisa
                    {
                        Login = x.owner.login,
                    },
                    Updated_at = x.updated_at
                })
            };            
        }

        public List<RepositorioContribuidoresGitHubResponse> ListarContribuidores(string username, string nomeRepositorio)
        {
            var result = _gitHub.ListarContribuidores(username, nomeRepositorio);

            var contribuidores = result.ConvertAll(x => new RepositorioContribuidoresGitHubResponse
            {
                Login = x.login,
                Avatar_url = x.avatar_url,
                Contributions = x.contributions,
                Html_url = x.html_url
            });

            return contribuidores;
        }
    }
}
