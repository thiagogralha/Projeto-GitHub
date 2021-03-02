using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using TesteTres.Infrastructure.Core.GitHub;

namespace TesteTres.Infrastructure.CrossCutting.GitHub
{
    public class GitHub
    {
        public GitHubOptions Options { get; }

        public GitHub(IOptions<GitHubOptions> optionsAccessor)
        {
            Options = optionsAccessor.Value;
        }

        public List<RepositorioGitHub> ListarRepositorios(string username)
        {
            var responseContent = new List<RepositorioGitHub>();

            using var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("TesteTres.API", "V1"));
            client.DefaultRequestHeaders.Accept.Clear();
            var url = $"{Options.UrlBase}/users/{username}/repos";
            var response = client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
                responseContent = JsonConvert.DeserializeObject<List<RepositorioGitHub>>(response.Content.ReadAsStringAsync().Result);

            return responseContent;
        }

        public RepositorioGitHub DetalhesDoRepositorio(string username, string nomeRepositorio)
        {            
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("TesteTres.API", "V1"));
            client.DefaultRequestHeaders.Accept.Clear();
            var url = $"{Options.UrlBase}/repos/{username}/{nomeRepositorio}";
            var response = client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<RepositorioGitHub>(response.Content.ReadAsStringAsync().Result);

            return null;
        }

        public RepositorioPesquisaGitHub PesquisarRepositorios(string nomeRepositorio)
        {            
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("TesteTres.API", "V1"));
            client.DefaultRequestHeaders.Accept.Clear();
            var url = $"{Options.UrlBase}/search/repositories?q={nomeRepositorio}&type=repository";
            var response = client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<RepositorioPesquisaGitHub>(response.Content.ReadAsStringAsync().Result);

            return null;
        }

        public List<RepositorioContribuidoresGitHub> ListarContribuidores(string username, string nomeRepositorio)
        {
            var responseContent = new List<RepositorioContribuidoresGitHub>();

            using var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("TesteTres.API", "V1"));
            client.DefaultRequestHeaders.Accept.Clear();
            var url = $"{Options.UrlBase}/repos/{username}/{nomeRepositorio}/contributors";
            var response = client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
                responseContent = JsonConvert.DeserializeObject<List<RepositorioContribuidoresGitHub>>(response.Content.ReadAsStringAsync().Result);

            return responseContent;
        }
    }
}
