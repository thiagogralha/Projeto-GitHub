using System;

namespace TesteTres.Infrastructure.CrossCutting.GitHub
{
    public class RepositorioGitHub
    {
        public string name { get; set; }
        public string description { get; set; }
        public string language { get; set; }
        public DateTime updated_at { get; set; }
        public Owner owner { get; set; }
    }

    public class Owner
    {
        public string login { get; set; }
    }
}
