using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportsTeams.Database;
using SportsTeams.Model;
using SportsTeams.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsTeams.Services
{
    public class CountryService : ICountryService
    {

        private readonly AppDbContext _appDbContext;
        protected readonly IMapper _mapper;

        public CountryService(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Model.Country>> Get(CountryParameters countryParameters)
        {
            return await _appDbContext.Countries.OrderBy(o => o.Name)
                .Skip((countryParameters.PageNumber - 1) * countryParameters.PageSize)
                .Take(countryParameters.PageSize)
                .Select(x => _mapper.Map<Model.Country>(x))
                .ToListAsync();
        }

        public async Task<Model.Country> GetById(int id)
        {
            var item = await _appDbContext.Countries.FindAsync(id);
            return _mapper.Map<Model.Country>(item);
        }

        public async Task<Model.Country> Insert(CountryInsertRequest request)
        {
            var item = _mapper.Map<Database.Country>(request);
            await _appDbContext.Countries.AddAsync(item);
            await _appDbContext.SaveChangesAsync();
            return _mapper.Map<Model.Country>(item);
        }
        public async Task<Model.Country> Update(int id, CountryUpdateRequest request)
        {
            var item = await _appDbContext.Countries.FindAsync(id);
            _mapper.Map(request, item);
            await _appDbContext.SaveChangesAsync();
            return _mapper.Map<Model.Country>(item);
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
