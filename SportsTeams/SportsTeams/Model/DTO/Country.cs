using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsTeams.Model
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public byte[] Picture { get; set; }
        public string Capital { get; set; }
        public int Population { get; set; }
    }
}
