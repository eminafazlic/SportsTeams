using SportsTeams.Model;
using SportsTeams.Model.DTO.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsTeams.Services
{
    public interface IPlayerService
    {
        public Task<IEnumerable<Model.DTO.Player>> GetAllPlayers(int teamId, PageParameters pageParameters, string q = null);
        public Task<IEnumerable<Model.DTO.Player>> GetAllPlayersSortedById(int teamId, PageParameters pageParameters, string q = null);
        public Task<Model.DTO.Player> GetPlayerById(int id);

        public Task<Model.DTO.Player> InsertPlayer(PlayerInsertRequest request);

        public Task<Model.DTO.Player> UpdatePlayer(int id, PlayerUpdateRequest request);
        public Task DeletePlayer(int id);
    }
}
