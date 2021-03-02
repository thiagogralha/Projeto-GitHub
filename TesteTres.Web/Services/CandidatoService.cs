using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using TesteTres.Web.Models;

namespace TesteTres.Web.Services
{
    public class CandidatoService : ICandidatoService
    {
        private readonly HttpClient _httpClient;

        public CandidatoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CandidatoRespostaModel>> ListarTodosOsRepositorios(string username)
        {
            var servidor = "https://localhost:44347";
            var response = await _httpClient.GetAsync($"{servidor}/api/Candidato/repositorios?username={username}");

           return JsonSerializer.Deserialize<List<CandidatoRespostaModel>>(await response.Content.ReadAsStringAsync());
        }

        public async Task<DetalhesRepositorioRespostaModel> ConsultarDetalhesDoRepositorio(string username, string nomeRepositorio)
        {
            var servidor = "https://localhost:44347";
            var response = await _httpClient.GetAsync($"{servidor}/api/Candidato/detalhes/repositorio?username={username}&nomeRepositorio={nomeRepositorio}");

            return JsonSerializer.Deserialize<DetalhesRepositorioRespostaModel>(await response.Content.ReadAsStringAsync());
        }
    }
}
