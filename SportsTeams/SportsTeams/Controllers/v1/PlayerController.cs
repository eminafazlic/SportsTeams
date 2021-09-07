using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SportsTeams.Model;
using SportsTeams.Model.DTO.Requests;
using SportsTeams.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsTeams.Controllers.v1
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1")]
    [ApiExplorerSettings(GroupName = "v1")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        public IPlayerService _playerService { get; set; }
        ILogger<PlayerController> _logger;

        public PlayerController(IPlayerService playerService, ILogger<PlayerController> logger)
        {
            _playerService = playerService;
            _logger = logger;
        }

        [HttpGet(template: "teamid={teamId}")]
        public async Task<IActionResult> GetAllPlayers(int teamId, [FromQuery] PageParameters pageParameters, [FromQuery] string q)
        {
            return Ok(await _playerService.GetAllPlayers(teamId, pageParameters, q));
        }
        [HttpGet(template: "{id}")]
        public async Task<IActionResult> GetPlayerById(int id)
        {
            return Ok(await _playerService.GetPlayerById(id));
        }
        [HttpPost]
        public async Task<IActionResult> InsertPlayer([FromBody] PlayerInsertRequest request)
        {
            return Created("~/api/v1/player", await _playerService.InsertPlayer(request));
        }
        [HttpPut(template: "{id}")]
        public async Task<IActionResult> UpdatePlayer(int id, PlayerUpdateRequest request)
        {
            return Ok(await _playerService.UpdatePlayer(id, request));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlayer(int id)
        {
            await _playerService.DeletePlayer(id);
            return NoContent();
        }
    }
}
