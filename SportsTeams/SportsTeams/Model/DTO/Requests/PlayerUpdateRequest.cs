using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsTeams.Model.DTO.Requests
{
    public class PlayerUpdateRequest
    {
        [MinLength(3)]
        [MaxLength(30)]
        [RegularExpression("^[a-zA-Z šđžćč]*$", ErrorMessage = "Only alphabet")]
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        [MinLength(3)]
        [MaxLength(30)]
        [RegularExpression("^[a-zA-Z šđžćč]*$", ErrorMessage = "Only alphabet")]
        public string PlaceOfBirth { get; set; }
        [Range(10, 90, ErrorMessage = "Enter a year between 10 and 90")]
        public int Age { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Mora biti postojeća država, ali o tom potom")]
        public int CountryId { get; set; }
        [Range(0, float.MaxValue, ErrorMessage = "Only positive numbers")]
        public float MarketValue { get; set; }
        [MinLength(3)]
        [MaxLength(30)]
        [RegularExpression("^[a-zA-Z šđžćč]*$", ErrorMessage = "Only alphabet")]
        public string Position { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Mora biti postojeći tim, ali o tom potom")]
        public int TeamId { get; set; }
        [Url(ErrorMessage = "Only url link")]
        public string Picture { get; set; }
        public DateTime Joined { get; set; }
        public DateTime ConstractExpDate { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Only positive numbers")]
        public int Number { get; set; }
    }
}
