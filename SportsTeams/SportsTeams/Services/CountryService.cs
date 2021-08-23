using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportsTeams.Database;
using SportsTeams.Filters;
using SportsTeams.Model;
using SportsTeams.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.ModelBinding;

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

        public async Task<IEnumerable<Model.Country>> GetAllCountries(CountryParameters countryParameters)
        {
            var list = await _appDbContext.Countries.OrderBy(o => o.Name)
                .Skip((countryParameters.PageNumber - 1) * countryParameters.PageSize)
                .Take(countryParameters.PageSize)
                .Select(x => _mapper.Map<Model.Country>(x))
                .ToListAsync();
            if (list == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return list;
        }

        public async Task<Model.Country> GetCountryById(int id)
        {
            var item = await _appDbContext.Countries.FindAsync(id);
            if(item==null)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent(string.Format($"Država s ID-jem {id} nije pronađena")),
                    ReasonPhrase = "ID nije pronađen"
                };
                throw new HttpResponseException(resp);
            }
            return _mapper.Map<Model.Country>(item);
        }

        [ValidateModel]
        public async Task<Model.Country> InsertCountry(CountryInsertRequest request)
        {
            try
            {
                var item = _mapper.Map<Database.Country>(request);
                await _appDbContext.Countries.AddAsync(item);
                await _appDbContext.SaveChangesAsync();
                return _mapper.Map<Model.Country>(item);
            }
            catch
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }
        public async Task<Model.Country> UpdateCountry(int id, CountryUpdateRequest request)
        {
            var item = await _appDbContext.Countries.FindAsync(id);
            if (item == null)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent(string.Format($"Država s ID-jem {id} nije pronađena")),
                    ReasonPhrase = "ID nije pronađen"
                };
                throw new HttpResponseException(resp);
            }
            try
            {
                _mapper.Map(request, item);
                await _appDbContext.SaveChangesAsync();
                return _mapper.Map<Model.Country>(item);
            }
            catch
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }

        public async Task DeleteCountry(int id)
        { 
            var item = await _appDbContext.Countries.FindAsync(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            _appDbContext.Countries.Remove(item);
        }
    }
}
