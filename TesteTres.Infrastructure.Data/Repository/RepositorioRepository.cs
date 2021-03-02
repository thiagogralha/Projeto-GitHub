using LiteDB;
using System.Collections.Generic;
using System.Linq;
using TesteTres.Domain.Entity;
using TesteTres.Domain.Interface.Repository;

namespace TesteTres.Infrastructure.Data.Repository
{
    public class RepositorioRepository : IRepositorioRepository
    {
        public List<Repositorio> ConsultarTodosFavoritos()
        {
            using (var db = new LiteDatabase("banco.db"))
            {
                var repositorios = db.GetCollection<Repositorio>("Repositorios");

                return repositorios.FindAll().ToList();
            }
        }

        public Repositorio InserirFavorito(Repositorio repositorio)
        {
            using (var db = new LiteDatabase("banco.db"))
            {
                var repositorioCollection = db.GetCollection<Repositorio>("Repositorios");

                repositorioCollection.Insert(repositorio);

                return repositorio;
            }
        }
    }
}
