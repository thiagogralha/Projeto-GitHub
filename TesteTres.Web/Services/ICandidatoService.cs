using System.Collections.Generic;
using System.Threading.Tasks;
using TesteTres.Web.Models;

namespace TesteTres.Web.Services
{
    public interface ICandidatoService
    {
        Task<List<CandidatoRespostaModel>> ListarTodosOsRepositorios(string username);
        Task<DetalhesRepositorioRespostaModel> ConsultarDetalhesDoRepositorio(string username, string nomeRepositorio);
    }
}
