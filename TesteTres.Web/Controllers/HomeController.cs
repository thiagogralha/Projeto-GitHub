using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TesteTres.Web.Models;
using TesteTres.Web.Services;

namespace TesteTres.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICandidatoService _candidatoService;
        private readonly IRepositorioService _repositorioService;

        public HomeController(
            ICandidatoService candidatoService,
            IRepositorioService repositorioService)
        {
            _candidatoService = candidatoService;
            _repositorioService = repositorioService;
        }

        public async Task<IActionResult> Index()
        {
            var resposta = await _candidatoService.ListarTodosOsRepositorios("thiagogralha");

            return View(resposta);
        }

        public async Task<IActionResult> DetalhesDoRepositorio(string username, string nomeRepositorio)
        {
            var resposta = await _candidatoService.ConsultarDetalhesDoRepositorio(username, nomeRepositorio);
            resposta.Contribuidores = await _repositorioService.ListarContribuidores(username, nomeRepositorio);

            return View(resposta);
        }

        [HttpPost]
        public async Task<IActionResult> InserirFavorito(InserirFavoritoViewModel model)
        {
           
            var modelFavorito = new InserirFavoritoViewModel
            {
                Description = model.Description,
                Language = model.Language,
                Name = model.Name,
                Owner = model.Owner,
                Updated_at = model.Updated_at
            };

            await _repositorioService.InserirFavorito(modelFavorito);

            return RedirectToAction("ConsultarTodosFavoritos", "Repositorio");
        }

    }
}
