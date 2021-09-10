﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SportsTeams.Database;
using SportsTeams.Model;
using SportsTeams.Model.DTO.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportsTeams.EF;
using System.Web.Http;
using System.Net;
using Microsoft.Extensions.Logging;
using System.Net.Http;

namespace SportsTeams.Services
{
    public class TeamService : ITeamService
    {
        private readonly AppDbContext _appDbContext;
        protected readonly IMapper _mapper;
        protected readonly ILogger<TeamService> _logger;

        public TeamService(AppDbContext appDbContext, IMapper mapper, ILogger<TeamService> logger)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<IEnumerable<Model.Team>> GetAllTeams(PageParameters pageParameters, string q = null)
        {
            _logger.LogInformation($"Izvršava se {nameof(GetAllTeams)} metoda sa modelom {nameof(PageParameters)} i parametrima {nameof(pageParameters.PageNumber)} {pageParameters.PageNumber} i {nameof(pageParameters.PageNumber)} {pageParameters.PageSize}");
            var countries = await _appDbContext.Countries.ToListAsync();
            var list = await _appDbContext.Teams
                .Where(x => q == null || x.Name.Contains(q))
                .Skip((pageParameters.PageNumber - 1) * pageParameters.PageSize)
                .Take(pageParameters.PageSize)
                .OrderBy(o => o.Name)
                .Select(x => _mapper.Map<Model.Team>(x))
                .ToListAsync();
            /*if (list.Count == 0)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    ReasonPhrase = $"Lista timova je prazna"
                };
                throw new HttpResponseException(resp);
            }*/
            return list;
        }
        public async Task<IEnumerable<Model.Team>> GetAllTeamsSortedById(PageParameters pageParameters, string q = null)
        {
            // promjena plana, ipak sortira po marketvalue
            _logger.LogInformation($"Izvršava se {nameof(GetAllTeamsSortedById)} metoda sa modelom {nameof(PageParameters)} i parametrima {nameof(pageParameters.PageNumber)} {pageParameters.PageNumber} i {nameof(pageParameters.PageNumber)} {pageParameters.PageSize}");
            var countries = await _appDbContext.Countries.ToListAsync();
            var list = await _appDbContext.Teams
                .Where(x => q == null || x.Name.Contains(q))
                .Skip((pageParameters.PageNumber - 1) * pageParameters.PageSize)
                .Take(pageParameters.PageSize)
                .OrderByDescending(o => o.MarketValue)
                .Select(x => _mapper.Map<Model.Team>(x))
                .ToListAsync();
            /*if (list.Count == 0)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    ReasonPhrase = $"Lista timova je prazna"
                };
                throw new HttpResponseException(resp);
            }*/
            return list;
        }

        public async Task<IEnumerable<Model.Team>> GetTeamsByCountryId(PageParameters pageParameters, int countryId)
        {
            _logger.LogInformation($"Izvršava se {nameof(GetTeamsByCountryId)} metoda sa modelom {nameof(PageParameters)} i parametrima {nameof(pageParameters.PageNumber)} {pageParameters.PageNumber} i {nameof(pageParameters.PageNumber)} {pageParameters.PageSize} i {nameof(countryId)} {countryId}");
            var country = await _appDbContext.Countries.FindAsync(countryId);
            if (country != null)
            {
                return await _appDbContext.Teams
                   .Where(y => y.CountryId == countryId)
                   .OrderBy(o => o.Name)
                   .Skip((pageParameters.PageNumber - 1) * pageParameters.PageSize)
                   .Take(pageParameters.PageSize)
                   .Select(x => _mapper.Map<Model.Team>(x))
                   .ToListAsync();
            }
            else
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    ReasonPhrase = $"Nije pronađena država s ID-jem {countryId}"
                };
                throw new HttpResponseException(resp);
            }
        }

        public async Task<Model.Team> GetTeamById(int id)
        {
            _logger.LogInformation($"Izvršava se {nameof(GetTeamById)} metoda sa parametrom {nameof(id)} {id}");
            var item = await _appDbContext.Teams.FindAsync(id);
            if (item == null)
            {

                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    ReasonPhrase = $"Nije pronađen tim s ID-jem {id}"
                };
                throw new HttpResponseException(resp);
                //throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            var country = await _appDbContext.Countries.FindAsync(item.CountryId);
            return _mapper.Map<Model.Team>(item);
        }

        public async Task<Model.Team> InsertTeam(TeamInsertRequest request)
        {
            _logger.LogInformation($"Izvršava se {nameof(InsertTeam)} metoda sa modelom {nameof(TeamInsertRequest)} i parametrima {nameof(request.Name)} {request.Name}, {nameof(request.Picture)} {request.Picture}, {nameof(request.CountryId)} {request.CountryId}, {nameof(request.Founded)} {request.Founded}, {nameof(request.HeadCoach)} {request.HeadCoach}, {nameof(request.HomeGround)} {request.HomeGround}, {nameof(request.League)} {request.League}, {nameof(request.MarketValue)} {request.MarketValue}, {nameof(request.NumberOfPlayers)} {request.NumberOfPlayers}, {nameof(request.President)} {(request.President)}, {nameof(request.StadiumCapacity)} {request.StadiumCapacity}");
            try
            {
                var country = await _appDbContext.Countries.FindAsync(request.CountryId);
                var item = _mapper.Map<Database.Team>(request);
                await _appDbContext.Teams.AddAsync(item);
                await _appDbContext.SaveChangesAsync();
                return _mapper.Map<Model.Team>(item);
            }
            catch
            {
                //throw new HttpResponseException(HttpStatusCode.BadRequest);
                var resp = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    ReasonPhrase = $"Neuspješan insert"
                };
                throw new HttpResponseException(resp);
            }
        }
        public async Task<Model.Team> UpdateTeam(int id, TeamUpdateRequest request)
        {
            _logger.LogInformation($"Izvršava se {nameof(UpdateTeam)} metoda sa modelom {nameof(TeamInsertRequest)} za {nameof(id)} {id} sa parametrima {nameof(request.Name)} {request.Name}, {nameof(request.Picture)} {request.Picture}, {nameof(request.CountryId)} {request.CountryId}, {nameof(request.Founded)} {request.Founded}, {nameof(request.HeadCoach)} {request.HeadCoach}, {nameof(request.HomeGround)} {request.HomeGround}, {nameof(request.League)} {request.League}, {nameof(request.MarketValue)} {request.MarketValue}, {nameof(request.NumberOfPlayers)} {request.NumberOfPlayers}, {nameof(request.President)} {(request.President)}, {nameof(request.StadiumCapacity)} {request.StadiumCapacity}");
            var item = await _appDbContext.Teams.FindAsync(id);
            if (item == null)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    ReasonPhrase = $"Nije pronađen tim s ID-jem {id}"
                };
                throw new HttpResponseException(resp);
            }
            try
            {
                var country = await _appDbContext.Countries.FindAsync(request.CountryId);
                _mapper.Map(request, item);
                await _appDbContext.SaveChangesAsync();
                return _mapper.Map<Model.Team>(item);
            }
            catch
            {
                var resp = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    ReasonPhrase = $"Neuspješan update"
                };
                throw new HttpResponseException(resp);
                //throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }

        public async Task DeleteTeam(int id)
        {
            _logger.LogInformation($"Izvršava se {nameof(DeleteTeam)} metoda sa parametrom {nameof(id)} {id}");
            var item = await _appDbContext.Teams.FindAsync(id);
            if (item == null)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    ReasonPhrase = $"Nije pronađen tim s ID-jem {id}"
                };
                throw new HttpResponseException(resp);
            }
            _appDbContext.Teams.Remove(item);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
