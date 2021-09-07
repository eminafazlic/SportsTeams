using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsTeams.Model.DTO.Requests
{
    public class PlayerInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        [MinLength(3)]
        [MaxLength(30)]
        [RegularExpression("^[a-zA-Z šđžćč]*$", ErrorMessage = "Only alphabet")]
        public string Name { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(3)]
        [MaxLength(30)]
        [RegularExpression("^[a-zA-Z šđžćč]*$", ErrorMessage = "Only alphabet")]
        public string PlaceOfBirth { get; set; }
        [Required]
        [Range(10, 90, ErrorMessage = "Enter a year between 10 and 90")]
        public int Age { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Range(1, int.MaxValue, ErrorMessage = "Mora biti postojeća država, ali o tom potom")]
        public int CountryId { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Range(0, float.MaxValue, ErrorMessage = "Only positive numbers")]
        public float MarketValue { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(3)]
        [MaxLength(30)]
        [RegularExpression("^[a-zA-Z šđžćč]*$", ErrorMessage = "Only alphabet")]
        public string Position { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Range(1, int.MaxValue, ErrorMessage = "Mora biti postojeći tim, ali o tom potom")]
        public int TeamId { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Url(ErrorMessage = "Only url link")]
        public string Picture { get; set; }
        [Required]
        public DateTime Joined { get; set; }
        [Required]
        public DateTime ConstractExpDate { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Range(0, int.MaxValue, ErrorMessage = "Only positive numbers")]
        public int Number { get; set; }
    }
}
