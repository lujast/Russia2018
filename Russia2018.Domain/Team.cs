using System.Collections.Generic;

namespace Russia2018.Domain
{
    public class Team
    {
        public int Id { get; set; }

        public virtual Country Country { get; set; }

        public virtual FiFaFederation FifaFederation {get;set;}

        public string  Alias { get; set; }

        public virtual Coach Coach { get; set; }

        public string AdditionalInfo { get; set; }

        public virtual List<Player> Players { get; set; }

        public virtual Player OriginalCaptain { get; set; }

    }
}