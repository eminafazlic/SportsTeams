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
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MaxLength(4)]
        public string Abbreviation { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Picture { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Capital { get; set; }
        [Required(AllowEmptyStrings = false)]
        public int Population { get; set; }
    }
}