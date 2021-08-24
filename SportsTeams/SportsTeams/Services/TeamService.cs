using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SportsTeams.Database;
using SportsTeams.Model;
using SportsTeams.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportsTeams.EF;

namespace SportsTeams.Services
{
    public class TeamService : ITeamService
    {
        private readonly AppDbContext _appDbContext;
        protected readonly IMapper _mapper;

        public TeamService(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Model.Team>> GetAllTeams(PageParameters pageParameters)
        {

            return await _appDbContext.Teams.OrderBy(o => o.Name)
                .Skip((pageParameters.PageNumber - 1) * pageParameters.PageSize)
                .Take(pageParameters.PageSize)
                .Select(x => _mapper.Map<Model.Team>(x))
                .ToListAsync();
        }
        public async Task<IEnumerable<Model.Team>> GetAllTeamsSortedById(PageParameters pageParameters)
        {

            return await _appDbContext.Teams.OrderBy(o => o.Id)
                .Skip((pageParameters.PageNumber - 1) * pageParameters.PageSize)
                .Take(pageParameters.PageSize)
                .Select(x => _mapper.Map<Model.Team>(x))
                .ToListAsync();
        }

        public async Task<IEnumerable<Model.Team>> GetTeamsByCountryId(PageParameters pageParameters, int countryId)
        {
            return await _appDbContext.Teams
               .Where(y => y.CountryId == countryId)
               .OrderBy(o => o.Name)
               .Skip((pageParameters.PageNumber - 1) * pageParameters.PageSize)
               .Take(pageParameters.PageSize)
               .Select(x => _mapper.Map<Model.Team>(x))
               .ToListAsync();
        }

        public async Task<Model.Team> GetTeamById(int id)
        {
            var item = await _appDbContext.Teams.FindAsync(id);
            return _mapper.Map<Model.Team>(item);
        }

        public async Task<Model.Team> InsertTeam(TeamInsertRequest request)
        {
            var item = _mapper.Map<Database.Team>(request);
            await _appDbContext.Teams.AddAsync(item);
            await _appDbContext.SaveChangesAsync();
            return _mapper.Map<Model.Team>(item);
        }
        public async Task<Model.Team> UpdateTeam(int id, TeamUpdateRequest request)
        {
            var item = await _appDbContext.Countries.FindAsync(id);
            _mapper.Map(request, item);
            await _appDbContext.SaveChangesAsync();
            return _mapper.Map<Model.Team>(item);
        }

        public async Task DeleteTeam(int id)
        {
            var item = await _appDbContext.Teams.FindAsync(id);
            if (item == null)
            {
                // return not found or smth
            }
            _appDbContext.Teams.Remove(item);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
