using System.Collections.Generic;
using System.Threading.Tasks;
using TesteTres.Web.Models;

namespace TesteTres.Web.Services
{
    public interface IRepositorioService
    {
        Task<List<RepositorioContribuidoresRespostaModel>> ListarContribuidores(string username, string nomeRepositorio);
        Task<PesquisarRepositorioViewModel> Pesquisar(string nomeRepositorio);
        Task<List<ConsultarFavoritoViewModel>> ConsultarTodosFavoritos();
        Task<InserirFavoritoRespostaViewModel> InserirFavorito(InserirFavoritoViewModel entrada);
    }
}
