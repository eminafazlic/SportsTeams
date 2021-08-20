using SportsTeams.Database;
using SportsTeams.Model;
using SportsTeams.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsTeams.Services
{
    public interface ITeamService
    {
        public Task<IEnumerable<Model.Team>> Get(CountryParameters countryParameters);
        public Task<Model.Team> GetById(int id);
        public Task<Model.Team> Insert(TeamInsertRequest request);

        public Task<Model.Team> Update(int id, TeamUpdateRequest request);
        public Task Delete(int id);
    }
}
