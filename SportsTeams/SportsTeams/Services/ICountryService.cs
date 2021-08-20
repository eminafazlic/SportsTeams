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
        public Task<IEnumerable<Model.Country>> Get(CountryParameters countryParameters);
        public Task<Model.Country> GetById(int id);
        public Task<Model.Country> Insert(CountryInsertRequest request);
        public Task<Model.Country> Update(int id, CountryUpdateRequest request);
        public Task Delete(int id);
    }
}
