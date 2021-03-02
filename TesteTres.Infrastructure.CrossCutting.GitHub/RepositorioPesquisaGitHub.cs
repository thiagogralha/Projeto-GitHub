using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTres.Infrastructure.CrossCutting.GitHub
{
    public class RepositorioPesquisaGitHub
    {
        public int total_count { get; set; }
        public List<ItemsPesquisa> items { get; set; }
    }

    public class ItemsPesquisa
    {
        public string name { get; set; }
        public string description { get; set; }
        public string language { get; set; }
        public DateTime updated_at { get; set; }
        public OwnerPesquisa owner { get; set; }
    }

    public class OwnerPesquisa
    {
        public string login { get; set; }
    }
}
