using System.Collections.Generic;

namespace Russia2018.Domain
{
    public class FiFaFederation
    {
        public int Id { get; set; }

        public string ShortName { get; set; }

        public string FullName { get; set; }

        public virtual Continent Continent { get; set; }

        public virtual List<Team> Teams { get; set; }
    }
}