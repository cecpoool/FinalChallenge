using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeSem22019.Models
{
    public class Game
    {
        public int ID { get; set; }

        public string Team1 { get; set; }

        public string Team2 { get; set; }

        public string Venue { get; set; }

        public DateTime TimeOfDate { get; set; }

        public bool Paid { get; set; }

        public string Payer { get; set; }

        public float? CourtFees { get; set; }

    }
}
