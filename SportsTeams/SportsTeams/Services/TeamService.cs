using AutoMapper;
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
    public class TeamService : ITeamService
    {
        private readonly AppDbContext _appDbContext;
        protected readonly IMapper _mapper;

        public TeamService(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Model.Team>> Get(CountryParameters countryParameters)
        {
            /*return await _appDbContext.Teams.OrderBy(o => o.Name).ThenBy(i => i.Id)
                .Skip((countryParameters.PageNumber - 1) * countryParameters.PageSize)
                .Take(countryParameters.PageSize).ToListAsync();*/

            return await _appDbContext.Teams.OrderBy(o => o.Name)
                .Skip((countryParameters.PageNumber - 1) * countryParameters.PageSize)
                .Take(countryParameters.PageSize)
                .Select(x => _mapper.Map<Model.Team>(x))
                .ToListAsync();
        }

        public async Task<Model.Team> GetById(int id)
        {
            var item = await _appDbContext.Teams.FindAsync(id);
            return _mapper.Map<Model.Team>(item);
        }

        public async Task<Model.Team> Insert(TeamInsertRequest request)
        {
            var item = _mapper.Map<Database.Team>(request);
            await _appDbContext.Teams.AddAsync(item);
            await _appDbContext.SaveChangesAsync();
            return _mapper.Map<Model.Team>(item);
        }
        public async Task<Model.Team> Update(int id, TeamUpdateRequest request)
        {
            var item = await _appDbContext.Countries.FindAsync(id);
            _mapper.Map(request, item);
            await _appDbContext.SaveChangesAsync();
            return _mapper.Map<Model.Team>(item);
        }

        public async Task Delete(int id)
        {
            var item = await _appDbContext.Teams.FindAsync(id);
            if (item == null)
            {
                // return not found or smth
            }
            _appDbContext.Teams.Remove(item);
        }
    }
}
