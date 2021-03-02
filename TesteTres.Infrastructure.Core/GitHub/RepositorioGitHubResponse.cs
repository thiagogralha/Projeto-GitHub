using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTres.Infrastructure.Core.GitHub
{
    public class RepositorioGitHubResponse
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public DateTime Updated_at { get; set; }
        public Owner Owner { get; set; }
    }

    public class Owner
    {
        public string Login { get; set; }
    }
}
