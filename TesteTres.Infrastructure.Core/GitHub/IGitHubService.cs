using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTres.Infrastructure.Core.GitHub
{
    public interface IGitHubService
    {
        List<RepositorioGitHubResponse> ListarRepositorios(string username);
        RepositorioGitHubResponse DetalhesDoRepositorio(string username, string nomeRepositorio);
        RepositorioPesquisaGitHubResponse PesquisarRepositorios(string nomeRepositorio);
        List<RepositorioContribuidoresGitHubResponse> ListarContribuidores(string username, string nomeRepositorio);
    }
}
