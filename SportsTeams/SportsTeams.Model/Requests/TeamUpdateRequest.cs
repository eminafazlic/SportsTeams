﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SportsTeams.Model.Requests
{
    public class TeamUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Picture { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public int Founded { get; set; }
        public string HomeGround { get; set; }
        public int StadiumCapacity { get; set; }
        public int MarketValue { get; set; }
        public int NumberOfPlayers { get; set; }
        public string HeadCoach { get; set; }
        public string President { get; set; }
        public string League { get; set; }
    }
}