using Microsoft.EntityFrameworkCore;
using SportsTeams.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsTeams.Services
{
    public class TeamService : ITeamService
    {
        private readonly AppDbContext _appDbContext;

        public TeamService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Team>> Get(CountryParameters countryParameters)
        {
            return await _appDbContext.Teams.OrderBy(o => o.Name).ThenBy(i => i.Id)
                .Skip((countryParameters.PageNumber - 1) * countryParameters.PageSize)
                .Take(countryParameters.PageSize).ToListAsync();
        }

        public async Task<Team> GetById(int id)
        {
            return await _appDbContext.Teams.FindAsync(id);
        }

        public async Task Insert(Team team)
        {
            await _appDbContext.Teams.AddAsync(team);
            await _appDbContext.SaveChangesAsync();
        }
        public async Task Update(int id, Team team)
        {
            var item = await _appDbContext.Teams.FindAsync(id);
            if (item != null)
            {
                // promjene itema ... ???
            }
            await _appDbContext.SaveChangesAsync();
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
