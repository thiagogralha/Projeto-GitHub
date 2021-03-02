using System.Collections.Generic;
using TesteTres.Domain.Entity;

namespace TesteTres.Domain.Interface.Service
{
    public interface IRepositorioService
    {
        List<Repositorio> ConsultarTodosFavoritos();
        Repositorio InserirFavorito(Repositorio repositorio);
    }
}
