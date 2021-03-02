using System;
using System.Collections.Generic;

namespace TesteTres.Web.Models
{
    public class PesquisarRepositorioViewModel
    {
        public string NomeRepositorio { get; set; }
        public int Total_count { get; set; }
        public List<ItemsPesquisa> Items { get; set; } = new List<ItemsPesquisa>();
    }

    public class ItemsPesquisa
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public DateTime Updated_at { get; set; }
        public OwnerPesquisa Owner { get; set; }
    }

    public class OwnerPesquisa
    {
        public string Login { get; set; }
    }
}
