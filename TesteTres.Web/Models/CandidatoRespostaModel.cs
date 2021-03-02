using System;

namespace TesteTres.Web.Models
{
    public class CandidatoRespostaModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public DateTime Updated_at { get; set; }
        public OwnerRepostaModel Owner { get; set; }
    }

    public class OwnerRepostaModel
    {
        public string Login { get; set; }
    }
}
