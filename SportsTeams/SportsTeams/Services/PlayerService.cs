using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SportsTeams.EF;
using SportsTeams.Model;
using SportsTeams.Model.DTO.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace SportsTeams.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly AppDbContext _appDbContext;
        protected readonly IMapper _mapper;
        protected readonly ILogger<PlayerService> _logger;
        public PlayerService(AppDbContext appDbContext, IMapper mapper, ILogger<PlayerService> logger)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<IEnumerable<Model.DTO.Player>> GetAllPlayers(PageParameters pageParameters, string q = null, int teamId = 0)
        {
            /*_logger.LogInformation($"Izvršava se {nameof(GetAllPlayers)} metoda sa modelom {nameof(PageParameters)} i parametrima {nameof(pageParameters.PageNumber)} {pageParameters.PageNumber} i {nameof(pageParameters.PageNumber)} {pageParameters.PageSize}");
            var countries = await _appDbContext.Countries.ToListAsync();
            var team = await _appDbContext.Teams.FindAsync(teamId);
            if (team == null)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    ReasonPhrase = $"Nije pronađen tim s ID-jem {teamId}"
                };
                throw new HttpResponseException(resp);
            }
            var list = await _appDbContext.Players
                .Where(x => teamId == 0 || x.TeamId == teamId)
                .Where(x => q == null || x.Name.Contains(q))
                .Skip((pageParameters.PageNumber - 1) * pageParameters.PageSize)
                .Take(pageParameters.PageSize)
                .OrderBy(o => o.Name)
                .Select(x => _mapper.Map<Model.DTO.Player>(x))
                .ToListAsync();
            return list;*/
            _logger.LogInformation($"Izvršava se {nameof(GetAllPlayersSortedById)} metoda sa modelom {nameof(PageParameters)} i parametrima {nameof(pageParameters.PageNumber)} {pageParameters.PageNumber} i {nameof(pageParameters.PageNumber)} {pageParameters.PageSize}");
            var countries = await _appDbContext.Countries.ToListAsync();
            if (teamId == 0)
            {
                var teams = await _appDbContext.Teams.ToListAsync();

                var list = await _appDbContext.Players
                .Where(x => q == null || x.Name.Contains(q))
                .Skip((pageParameters.PageNumber - 1) * pageParameters.PageSize)
                .Take(pageParameters.PageSize)
                .OrderBy(o => o.Id)
                .Select(x => _mapper.Map<Model.DTO.Player>(x))
                .ToListAsync();
                return list;
            }
            else
            {
                var team = await _appDbContext.Teams.FindAsync(teamId);
                if (team == null)
                {
                    var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                    {
                        ReasonPhrase = $"Nije pronađen tim s ID-jem {teamId}"
                    };
                    throw new HttpResponseException(resp);
                }
                var list = await _appDbContext.Players
                    .Where(x => x.TeamId == teamId)
                    .Where(x => q == null || x.Name.Contains(q))
                    .Skip((pageParameters.PageNumber - 1) * pageParameters.PageSize)
                    .Take(pageParameters.PageSize)
                    .OrderBy(o => o.Id)
                    .Select(x => _mapper.Map<Model.DTO.Player>(x))
                    .ToListAsync();
                return list;
            }
        }
        public async Task<IEnumerable<Model.DTO.Player>> GetAllPlayersSortedById(PageParameters pageParameters, string q = null, int teamId = 0)
        {
            _logger.LogInformation($"Izvršava se {nameof(GetAllPlayersSortedById)} metoda sa modelom {nameof(PageParameters)} i parametrima {nameof(pageParameters.PageNumber)} {pageParameters.PageNumber} i {nameof(pageParameters.PageNumber)} {pageParameters.PageSize}");
            var countries = await _appDbContext.Countries.ToListAsync();
            if (teamId == 0)
            {
                var teams = await _appDbContext.Teams.ToListAsync();

                var list = await _appDbContext.Players
                .Where(x => q == null || x.Name.Contains(q))
                .Skip((pageParameters.PageNumber - 1) * pageParameters.PageSize)
                .Take(pageParameters.PageSize)
                .OrderBy(o => o.Id)
                .Select(x => _mapper.Map<Model.DTO.Player>(x))
                .ToListAsync();
                return list;
            }
            else
            {
                var team = await _appDbContext.Teams.FindAsync(teamId);
                if (team == null)
                {
                    var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                    {
                        ReasonPhrase = $"Nije pronađen tim s ID-jem {teamId}"
                    };
                    throw new HttpResponseException(resp);
                }
                var list = await _appDbContext.Players
                    .Where(x => x.TeamId == teamId)
                    .Where(x => q == null || x.Name.Contains(q))
                    .Skip((pageParameters.PageNumber - 1) * pageParameters.PageSize)
                    .Take(pageParameters.PageSize)
                    .OrderBy(o => o.Id)
                    .Select(x => _mapper.Map<Model.DTO.Player>(x))
                    .ToListAsync();
                return list;
            }
        }
        public async Task<Model.DTO.Player> GetPlayerById(int id)
        {
            _logger.LogInformation($"Izvršava se {nameof(GetPlayerById)} metoda sa parametrom {nameof(id)} {id}");
            var item = await _appDbContext.Players.FindAsync(id);
            if (item == null)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    ReasonPhrase = $"Nije pronađen igrač s ID-jem {id}"
                };
                throw new HttpResponseException(resp);
            }
            var country = await _appDbContext.Countries.FindAsync(item.CountryId);
            var team = await _appDbContext.Teams.FindAsync(item.TeamId);
            return _mapper.Map<Model.DTO.Player>(item);
        }

        public async Task<Model.DTO.Player> InsertPlayer(PlayerInsertRequest request)
        {
            _logger.LogInformation($"Izvršava se {nameof(InsertPlayer)} metoda sa modelom {nameof(PlayerInsertRequest)} i parametrima...");
            try
            {
                var country = await _appDbContext.Countries.FindAsync(request.CountryId);
                var team = await _appDbContext.Teams.FindAsync(request.TeamId);
                var item = _mapper.Map<Database.Player>(request);
                await _appDbContext.Players.AddAsync(item);
                await _appDbContext.SaveChangesAsync();
                return _mapper.Map<Model.DTO.Player>(item);
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

        public async Task<Model.DTO.Player> UpdatePlayer(int id, PlayerUpdateRequest request)
        {
            _logger.LogInformation($"Izvršava se {nameof(UpdatePlayer)} metoda sa modelom {nameof(PlayerInsertRequest)} za {nameof(id)} {id} sa parametrima...");
            var item = await _appDbContext.Players.FindAsync(id);
            if (item == null)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    ReasonPhrase = $"Nije pronađen igrač s ID-jem {id}"
                };
                throw new HttpResponseException(resp);
            }
            try
            {
                var country = await _appDbContext.Countries.FindAsync(request.CountryId);
                var team = await _appDbContext.Teams.FindAsync(request.TeamId);
                _mapper.Map(request, item);
                await _appDbContext.SaveChangesAsync();
                return _mapper.Map<Model.DTO.Player>(item);
            }
            catch
            {
                var resp = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    ReasonPhrase = $"Neuspješan update"
                };
                throw new HttpResponseException(resp);
            }
        }
        public async Task DeletePlayer(int id)
        {

            _logger.LogInformation($"Izvršava se {nameof(DeletePlayer)} metoda sa parametrom {nameof(id)} {id}");
            var item = await _appDbContext.Players.FindAsync(id);
            if (item == null)
            {
                var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    ReasonPhrase = $"Nije pronađen igrač s ID-jem {id}"
                };
                throw new HttpResponseException(resp);
            }
            _appDbContext.Players.Remove(item);
            await _appDbContext.SaveChangesAsync();
        }
    }
}