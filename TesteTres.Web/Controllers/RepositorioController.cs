using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TesteTres.Web.Models;
using TesteTres.Web.Services;

namespace TesteTres.Web.Controllers
{
    public class RepositorioController : Controller
    {        
        private readonly IRepositorioService _repositorioService;

        public RepositorioController(
            IRepositorioService repositorioService)
        {           
            _repositorioService = repositorioService;
        }

        public IActionResult Pesquisar()
        {
            var model = new PesquisarRepositorioViewModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Pesquisar(PesquisarRepositorioViewModel model)
        {
            var resposta = await _repositorioService.Pesquisar(model.NomeRepositorio);

            return View(resposta);
        }

        public async Task<IActionResult> ConsultarTodosFavoritos()
        {
            var model = await _repositorioService.ConsultarTodosFavoritos();

            return View(model);
        }
    }
}
