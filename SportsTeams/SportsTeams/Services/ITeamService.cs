using SportsTeams.Database;
using SportsTeams.Model;
using SportsTeams.Model.DTO.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsTeams.Services
{
    public interface ITeamService
    {
        public Task<IEnumerable<Model.Team>> GetAllTeams(PageParameters pageParameters, string q = null);
        public Task<IEnumerable<Model.Team>> GetAllTeamsSortedById(PageParameters pageParameters);
        public Task<Model.Team> GetTeamById(int id);

        public Task<IEnumerable<Model.Team>> GetTeamsByCountryId(PageParameters pageParameters, int countryId);
        public Task<Model.Team> InsertTeam(TeamInsertRequest request);

        public Task<Model.Team> UpdateTeam(int id, TeamUpdateRequest request);
        public Task DeleteTeam(int id);
    }
}
