using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteTres.API.Models.Repositorio;
using TesteTres.Domain.Entity;
using TesteTres.Domain.Interface.Service;
using TesteTres.Infrastructure.Core.GitHub;

namespace TesteTres.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepositorioController : ControllerBase
    {
        private readonly IGitHubService _gitHubService;
        private readonly IRepositorioService _repositorioService;

        public RepositorioController(IGitHubService gitHubService, IRepositorioService repositorioService)
        {
            _gitHubService = gitHubService;
            _repositorioService = repositorioService;
        }

        [HttpGet("pesquisar")]
        public IActionResult Pesquisar(string nomeRepositorio)
        {
            var resultado = _gitHubService.PesquisarRepositorios(nomeRepositorio);

            return Ok(resultado);
        }

        [HttpGet("listar/contribuidores")]
        public IActionResult ListarContribuidores(string username, string nomeRepositorio)
        {
            var resultado = _gitHubService.ListarContribuidores(username, nomeRepositorio);

            return Ok(resultado);
        }

        [HttpGet("consultarfavoritos")]
        public IActionResult ConsultarTodosFavoritos()
        {
            var resultado = _repositorioService.ConsultarTodosFavoritos();

            return Ok(resultado);
        }

        [HttpPost("inserirfavorito")]
        public IActionResult InserirFavorito(RepositorioRequest request)
        {
            var repositorio = new Repositorio
            {
                Description = request.Description,
                Language = request.Language,
                Name = request.Name,
                Owner = request.Owner.Login,
                Updated_at = request.Updated_at
            };

            var resultado = _repositorioService.InserirFavorito(repositorio);

            return Ok(resultado);
        }
    }
}
