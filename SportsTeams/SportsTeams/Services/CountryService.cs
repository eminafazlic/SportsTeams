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

        public async Task<IEnumerable<Model.Country>> GetAllCountries(PageParameters pageParameters, string q = null)
        {
            _logger.LogInformation($"Izvršava se {nameof(GetAllCountries)} metoda sa modelom {nameof(PageParameters)} i parametrima {nameof(pageParameters.PageNumber)} {pageParameters.PageNumber} i {nameof(pageParameters.PageNumber)} {pageParameters.PageSize}");
            var list = await _appDbContext.Countries
                .Where(x => q == null || x.Name.Contains(q))
                .Skip((pageParameters.PageNumber - 1) * pageParameters.PageSize)
                .Take(pageParameters.PageSize)
                .OrderBy(o => o.Name)
                .Select(x => _mapper.Map<Model.Country>(x))
                .ToListAsync();
            /*if (list.Count== 0)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    ReasonPhrase = "Lista država je prazna"
                };
                throw new HttpResponseException(resp);
            }*/
            return list;
        }

        public async Task<IEnumerable<Model.Country>> GetAllCountriesSortedById(PageParameters pageParameters, string q = null)
        {
            _logger.LogInformation($"Izvršava se {nameof(GetAllCountries)} metoda sa modelom {nameof(PageParameters)} i parametrima {nameof(pageParameters.PageNumber)} {pageParameters.PageNumber} i {nameof(pageParameters.PageNumber)} {pageParameters.PageSize}");
            var list = await _appDbContext.Countries
                .Where(x => q == null || x.Name.Contains(q))
                .Skip((pageParameters.PageNumber - 1) * pageParameters.PageSize)
                .Take(pageParameters.PageSize)
                .OrderBy(o => o.Id)
                .Select(x => _mapper.Map<Model.Country>(x))
                .ToListAsync();
            /*if (list.Count == 0)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    ReasonPhrase = $"Lista država je prazna"
                };
                throw new HttpResponseException(resp);
            }*/
            return list;
        }

        public async Task<Model.Country> GetCountryById(int id)
        {
            _logger.LogInformation($"Izvršava se {nameof(GetCountryById)} metoda sa parametrom {nameof(id)} {id}");
            var item = await _appDbContext.Countries.FindAsync(id);
            if (item == null)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    ReasonPhrase = $"Nije pronađena država s ID-jem {id}"
                };
                throw new HttpResponseException(resp);
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
                var resp = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    ReasonPhrase = $"Neuspješan insert"
                };
                throw new HttpResponseException(resp);
            }
        }
        public async Task<Model.Country> UpdateCountry(int id, CountryUpdateRequest request)
        {
            _logger.LogInformation($"Izvršava se {nameof(UpdateCountry)} metoda sa modelom {nameof(request)} za {nameof(id)} {id} sa parametrima {nameof(request.Name)} {request.Name}, {nameof(request.Picture)} {request.Picture}, {nameof(request.Population)} {request.Population}, {nameof(request.Abbreviation)} {request.Abbreviation}, {nameof(request.Capital)} {request.Capital}");
            var item = await _appDbContext.Countries.FindAsync(id);
            if (item == null)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    ReasonPhrase = $"Nije pronađena država s ID-jem {id}"
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
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    ReasonPhrase = $"Neuspješan update"
                };
                throw new HttpResponseException(resp);
            }
        }

        public async Task DeleteCountry(int id)
        {
            _logger.LogInformation($"Izvršava se {nameof(DeleteCountry)} metoda sa parametrom {nameof(id)} {id}");
            var item = await _appDbContext.Countries.FindAsync(id);
            if (item == null)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    ReasonPhrase = $"Nije pronađena država s ID-jem {id}"
                };
                throw new HttpResponseException(resp);
            }
            _appDbContext.Countries.Remove(item);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
