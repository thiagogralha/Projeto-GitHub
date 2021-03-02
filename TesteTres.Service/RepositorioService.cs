using System.Collections.Generic;
using TesteTres.Domain.Entity;
using TesteTres.Domain.Interface.Repository;
using TesteTres.Domain.Interface.Service;

namespace TesteTres.Service
{
    public class RepositorioService : IRepositorioService
    {
        private readonly IRepositorioRepository _iRepositorioRepository;

        public RepositorioService(IRepositorioRepository iRepositorioRepository)
        {
            _iRepositorioRepository = iRepositorioRepository;
        }

        public List<Repositorio> ConsultarTodosFavoritos()
        {
            return _iRepositorioRepository.ConsultarTodosFavoritos();
        }

        public Repositorio InserirFavorito(Repositorio repositorio)
        {
            return _iRepositorioRepository.InserirFavorito(repositorio);
        }
    }
}
