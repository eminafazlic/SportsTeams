using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            return await _appDbContext.Countries.OrderBy(o => o.Name).ThenBy(i => i.Id)
                .Skip((countryParameters.PageNumber - 1) * countryParameters.PageSize)
                .Take(countryParameters.PageSize).ToListAsync();
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
        public async Task Update(int id, Country country)
        {
            var item= await _appDbContext.Countries.FindAsync(id);
            if (item != null)
            {
                // promjene itema ... item.Name = country.Name; npr ?
            }
            await _appDbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        { 
            var item = await _appDbContext.Countries.FindAsync(id);
            if (item == null)
            {
                // return not found or smth
            }
            _appDbContext.Countries.Remove(item);
        }
    }
}
