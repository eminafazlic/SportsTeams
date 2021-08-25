using System;
using System.Collections.Generic;
using System.Text;

namespace SportsTeams.Model.DTO.Requests
{
    public class CountryUpdateRequest
    {
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        //public byte[] Picture { get; set; }
        public string Capital { get; set; }
        public int? Population { get; set; }
    }
}
