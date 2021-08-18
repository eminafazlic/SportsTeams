using SportsTeams.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsTeams.Services
{
    public interface ICountryService
    {
        public Task<IEnumerable<Country>> Get(CountryParameters countryParameters);
        public Task<Country> GetById(int id);
        public Task Insert(Country country);

        public Country Update(int id, Country country);
    }
}
