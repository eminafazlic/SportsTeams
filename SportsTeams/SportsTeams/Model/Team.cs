﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsTeams.Model
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[]? Picture { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public int Founded { get; set; } // godina osnivanja
        public string HomeGround { get; set; } // domaći stadion
        public int MarketValue { get; set; }
        public int NumberOfPlayers { get; set; }
    }
}
