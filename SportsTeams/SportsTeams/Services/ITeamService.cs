using SportsTeams.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsTeams.Services
{
    public interface ITeamService
    {
        public Task<IEnumerable<Team>> Get(CountryParameters countryParameters);
        public Task<Team> GetById(int id);
        public Task Insert(Team country);

        public Task Update(int id, Team country);
        public Task Delete(int id);
    }
}
