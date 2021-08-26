using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportsTeams.Database;
using SportsTeams.Filters;
using SportsTeams.Model;
using SportsTeams.Model.DTO.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using SportsTeams.EF;
using Microsoft.Extensions.Logging;

namespace SportsTeams.Services
{
    public class CountryService : ICountryService
    {

        private readonly AppDbContext _appDbContext;
        protected readonly IMapper _mapper;
        protected readonly ILogger<CountryService> _logger;

        public CountryService(AppDbContext appDbContext, IMapper mapper, ILogger<CountryService> logger)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<IEnumerable<Model.Country>> GetAllCountries(PageParameters pageParameters)
        {
            _logger.LogInformation($"Izvršava se {nameof(GetAllCountries)} metoda sa modelom {nameof(PageParameters)} i parametrima {nameof(pageParameters.PageNumber)} {pageParameters.PageNumber} i {nameof(pageParameters.PageNumber)} {pageParameters.PageSize}");
            var list = await _appDbContext.Countries.OrderBy(o => o.Name)
                .Skip((pageParameters.PageNumber - 1) * pageParameters.PageSize)
                .Take(pageParameters.PageSize)
                .Select(x => _mapper.Map<Model.Country>(x))
                .ToListAsync();
            if (list == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return list;
        }

        public async Task<IEnumerable<Model.Country>> GetAllCountriesSortedById(PageParameters pageParameters)
        {
            _logger.LogInformation($"Izvršava se {nameof(GetAllCountries)} metoda sa modelom {nameof(PageParameters)} i parametrima {nameof(pageParameters.PageNumber)} {pageParameters.PageNumber} i {nameof(pageParameters.PageNumber)} {pageParameters.PageSize}");
            var list = await _appDbContext.Countries.OrderBy(o => o.Id)
                .Skip((pageParameters.PageNumber - 1) * pageParameters.PageSize)
                .Take(pageParameters.PageSize)
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
            _logger.LogInformation($"Izvršava se {nameof(GetCountryById)} metoda sa parametrom {nameof(id)} {id}");
            var item = await _appDbContext.Countries.FindAsync(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return _mapper.Map<Model.Country>(item);
        }

        [ValidateModel]
        public async Task<Model.Country> InsertCountry(CountryInsertRequest request)
        {
            _logger.LogInformation($"Izvršava se {nameof(InsertCountry)} metoda sa modelom {nameof(CountryInsertRequest)} i parametrima {nameof(request.Name)} {request.Name}, {nameof(request.Picture)} {request.Picture}, {nameof(request.Population)} {request.Population}, {nameof(request.Abbreviation)} {request.Abbreviation}, {nameof(request.Capital)} {request.Capital}");
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
            _logger.LogInformation($"Izvršava se {nameof(UpdateCountry)} metoda sa modelom {nameof(request)} za {nameof(id)} {id} sa parametrima {nameof(request.Name)} {request.Name}, {nameof(request.Picture)} {request.Picture}, {nameof(request.Population)} {request.Population}, {nameof(request.Abbreviation)} {request.Abbreviation}, {nameof(request.Capital)} {request.Capital}");
            var item = await _appDbContext.Countries.FindAsync(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
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
            _logger.LogInformation($"Izvršava se {nameof(DeleteCountry)} metoda sa parametrom {nameof(id)} {id}");
            var item = await _appDbContext.Countries.FindAsync(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            _appDbContext.Countries.Remove(item);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
