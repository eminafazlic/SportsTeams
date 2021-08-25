using System;
using System.Collections.Generic;
using System.Text;

namespace SportsTeams.Model.DTO.Requests
{
    public class TeamUpdateRequest
    {
        public string Name { get; set; }
        //public byte[] Picture { get; set; }
        public int CountryId { get; set; }
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
