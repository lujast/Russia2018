using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russia2018.Domain
{
    public class Game
    {
        public int Id { get; set; }

        public GameType GameType { get; set; }

        public Team Host { get; set; }

        public Team Guest { get; set; }

        public Score Score { get; set; }

        public Referee Referee { get; set; }

        public Player ManOfTheMatch { get; set; }

        public Stadium Stadium { get; set; }

        public DateTime StartingDate { get; set; }

        public int NumberOfVisitors { get; set; }

        public string AdditinalInfo { get; set; }
    }
}
