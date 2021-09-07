using System;
using System.Collections.Generic;
using System.Text;

namespace SportsTeams.Database
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public int Age { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public float MarketValue { get; set; }
        public string Position { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public string Picture { get; set; }

        public DateTime Joined { get; set; }
        public DateTime ConstractExpDate { get; set; }
        public int Number { get; set; }
    }
}
