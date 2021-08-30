using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SportsTeams.Model.DTO.Requests
{
    public class TeamUpdateRequest
    {
        [MinLength(3)]
        [MaxLength(30)]
        [RegularExpression("^[a-zA-Z šđžćč]*$", ErrorMessage = "Only alphabet")]
        public string Name { get; set; }
        [Url(ErrorMessage = "Only url link")]
        public string Picture { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Mora biti postojeća država, ali o tom potom")]
        public int CountryId { get; set; }
        [Range(1700, 2021, ErrorMessage = "Enter a year between 1700 and 2021")]
        public int Founded { get; set; }
        [RegularExpression("^[a-zA-Z šđžćč]*$", ErrorMessage = "Only alphabet")]
        public string HomeGround { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Only positive numbers")]
        public int StadiumCapacity { get; set; }
        [Range(0, float.MaxValue, ErrorMessage = "Only positive numbers")]
        public int MarketValue { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Only positive numbers")]
        public int NumberOfPlayers { get; set; }
        [RegularExpression("^[a-zA-Z šđžćč]*$", ErrorMessage = "Only alphabet")]
        public string HeadCoach { get; set; }
        [RegularExpression("^[a-zA-Z šđžćč]*$", ErrorMessage = "Only alphabet")]
        public string President { get; set; }
        [RegularExpression("^[a-zA-Z šđžćč]*$", ErrorMessage = "Only alphabet")]
        public string League { get; set; }
    }
}
