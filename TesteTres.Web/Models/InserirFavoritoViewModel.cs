using System;

namespace TesteTres.Web.Models
{
    public class InserirFavoritoViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public DateTime Updated_at { get; set; }
        public OwnerViewModel Owner { get; set; }
    }

    public class OwnerViewModel
    {
        public string Login { get; set; }
    }
}
