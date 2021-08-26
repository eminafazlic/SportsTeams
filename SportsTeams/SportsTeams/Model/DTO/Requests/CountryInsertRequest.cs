using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SportsTeams.Model.DTO.Requests
{
    public class CountryInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        [MinLength(3)]
        [MaxLength(30)]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Only alphabet")]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false)]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Only alphabet")]
        public string Abbreviation { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Url(ErrorMessage = "Only url link")]
        public string Picture { get; set; }
        [Required(AllowEmptyStrings = false)]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Only alphabet")]
        public string Capital { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Range(1, int.MaxValue, ErrorMessage = "Only positive numbers")]
        public int Population { get; set; }
    }
}