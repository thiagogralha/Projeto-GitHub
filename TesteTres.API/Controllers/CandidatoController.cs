using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteTres.Infrastructure.Core.GitHub;

namespace TesteTres.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatoController : ControllerBase
    {
        private readonly IGitHubService _gitHubService;

        public CandidatoController(IGitHubService gitHubService)
        {
            _gitHubService = gitHubService;
        }

        [HttpGet("repositorios")]
        public IActionResult ListarRepositorios(string username)
        {
            var resultado = _gitHubService.ListarRepositorios(username);

            return Ok(resultado);
        }

        [HttpGet("detalhes/repositorio")]
        public IActionResult DetalhesDoRepositorio(string username, string nomeRepositorio)
        {
            var resultado = _gitHubService.DetalhesDoRepositorio(username, nomeRepositorio);

            return Ok(resultado);
        }
    }
}
