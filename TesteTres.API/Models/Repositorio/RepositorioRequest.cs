using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteTres.API.Models.Repositorio
{
    public class RepositorioRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public DateTime Updated_at { get; set; }
        public OwnerRequest Owner { get; set; }
    }

    public class OwnerRequest
    {
        public string Login { get; set; }
    }
}
