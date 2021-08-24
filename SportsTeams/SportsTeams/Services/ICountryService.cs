using SportsTeams.Database;
using SportsTeams.Model;
using SportsTeams.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsTeams.Services
{
    public interface ICountryService 
    {
        public Task<IEnumerable<Model.Country>> GetAllCountries(PageParameters pageParameters);
        public Task<IEnumerable<Model.Country>> GetAllCountriesSortedById(PageParameters pageParameters);
        public Task<Model.Country> GetCountryById(int id);
        public Task<Model.Country> InsertCountry(CountryInsertRequest request);
        public Task<Model.Country> UpdateCountry(int id, CountryUpdateRequest request);
        public Task DeleteCountry(int id);
    }
}
