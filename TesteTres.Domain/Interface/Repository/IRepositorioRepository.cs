using System;
using System.Collections.Generic;
using System.Text;
using TesteTres.Domain.Entity;

namespace TesteTres.Domain.Interface.Repository
{
    public interface IRepositorioRepository
    {
        List<Repositorio> ConsultarTodosFavoritos();
        Repositorio InserirFavorito(Repositorio repositorio);
    }
}
