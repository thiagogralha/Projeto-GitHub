using System;
using System.Collections.Generic;

namespace TesteTres.Web.Models
{
    public class DetalhesRepositorioRespostaModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public DateTime Updated_at { get; set; }
        public OwnerDetalhesRepositorioRepostaModel Owner { get; set; } = new OwnerDetalhesRepositorioRepostaModel();
        public List<RepositorioContribuidoresRespostaModel> Contribuidores { get; set; } = new List<RepositorioContribuidoresRespostaModel>();
    }

    public class OwnerDetalhesRepositorioRepostaModel
    {
        public string Login { get; set; }
    }

    public class RepositorioContribuidoresRespostaModel
    {
        public string Login { get; set; }
        public string Avatar_url { get; set; }
        public int Contributions { get; set; }
        public string Html_url { get; set; }
    }
}
