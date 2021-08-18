using Microsoft.AspNetCore.Mvc;
using SportsTeams.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsTeams.Services
{
    public class CountryService : ICountryService
    {

        private readonly AppDbContext _appDbContext;
        //private static List<Country> _countries;

        public CountryService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Country>> Get(CountryParameters countryParameters)
        {
            return _appDbContext.Countries.OrderBy(o => o.Name).ThenBy(i => i.Id)
                .Skip((countryParameters.PageNumber - 1) * countryParameters.PageSize)
                .Take(countryParameters.PageSize).ToList();
        }

        public async Task<Country> GetById(int id)
        {
            return await _appDbContext.Countries.FindAsync(id);
        }

        public async Task Insert(Country country)
        {
            await _appDbContext.Countries.AddAsync(country);
            await _appDbContext.SaveChangesAsync();
        }
        public Country Update(int id, Country country)
        {
            /*var current = _countries.FirstOrDefault(x => x.Id == id);
            current.Name = country.Name;
            return current;*/
            return country;
        }
    }
}
