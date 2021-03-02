using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TesteTres.Web.Models;

namespace TesteTres.Web.Services
{
    public class RepositorioService : IRepositorioService
    {
        private readonly HttpClient _httpClient;

        public RepositorioService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<RepositorioContribuidoresRespostaModel>> ListarContribuidores(string username, string nomeRepositorio)
        {
            var servidor = "https://localhost:44347";
            var response = await _httpClient.GetAsync($"{servidor}/api/Repositorio/listar/contribuidores?username={username}&nomeRepositorio={nomeRepositorio}");

            return JsonSerializer.Deserialize<List<RepositorioContribuidoresRespostaModel>>(await response.Content.ReadAsStringAsync());
        }

        public async Task<PesquisarRepositorioViewModel> Pesquisar(string nomeRepositorio)
        {
            var servidor = "https://localhost:44347";
            var response = await _httpClient.GetAsync($"{servidor}/api/Repositorio/pesquisar?nomeRepositorio={nomeRepositorio}");

            return JsonSerializer.Deserialize<PesquisarRepositorioViewModel>(await response.Content.ReadAsStringAsync());
        }

        public async Task<List<ConsultarFavoritoViewModel>> ConsultarTodosFavoritos()
        {
            var servidor = "https://localhost:44347";
            var response = await _httpClient.GetAsync($"{servidor}/api/Repositorio/consultarfavoritos");

            return JsonSerializer.Deserialize<List<ConsultarFavoritoViewModel>>(await response.Content.ReadAsStringAsync());
        }

        public async Task<InserirFavoritoRespostaViewModel> InserirFavorito(InserirFavoritoViewModel entrada)
        {
            var Repositoriocontent = new StringContent(
                JsonSerializer.Serialize(entrada),
                Encoding.UTF8,
                "application/json");

            var servidor = "https://localhost:44347";
            var response = await _httpClient.PostAsync($"{servidor}/api/Repositorio/inserirfavorito", Repositoriocontent);

            return JsonSerializer.Deserialize<InserirFavoritoRespostaViewModel>(await response.Content.ReadAsStringAsync());
        }
    }
}
