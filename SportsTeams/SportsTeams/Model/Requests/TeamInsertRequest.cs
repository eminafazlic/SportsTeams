using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SportsTeams.Model.Requests
{
    public class TeamInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
        /*[Required(AllowEmptyStrings = false)]
        public byte[] Picture { get; set; }*/
        [Required(AllowEmptyStrings = false)]
        public int CountryId { get; set; }
        [Required(AllowEmptyStrings = false)]
        public int Founded { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string HomeGround { get; set; }
        [Required(AllowEmptyStrings = false)]
        public int StadiumCapacity { get; set; }
        [Required(AllowEmptyStrings = false)]
        public int MarketValue { get; set; }
        [Required(AllowEmptyStrings = false)]
        public int NumberOfPlayers { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string HeadCoach { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string President { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string League { get; set; }
    }
}
