using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsTeams.Model.DTO
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
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
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Joined { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime ConstractExpDate { get; set; }
        public int Number { get; set; }
    }
}
