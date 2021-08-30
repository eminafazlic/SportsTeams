using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SportsTeams.Model.DTO.Requests
{
    public class CountryUpdateRequest
    {
        [RegularExpression("^[a-zA-Z šđžćč]*$", ErrorMessage = "Only alphabet")]
        public string Name { get; set; }
        [RegularExpression("^[a-zA-Z šđžćč]*$", ErrorMessage = "Only alphabet")]
        public string Abbreviation { get; set; }
        [Url(ErrorMessage = "Only url link")]
        public string Picture { get; set; }
        [RegularExpression("^[a-zA-Z šđžćč]*$", ErrorMessage = "Only alphabet")]
        public string Capital { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Only positive numbers")]
        public int Population { get; set; }
    }
}
