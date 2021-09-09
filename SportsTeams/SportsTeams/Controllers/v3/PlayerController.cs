using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SportsTeams.Model;
using SportsTeams.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsTeams.Controllers.v3
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("3")]
    [ApiExplorerSettings(GroupName = "v3")]
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

        [HttpGet]
        public async Task<IActionResult> GetAllPlayers([FromQuery] PageParameters pageParameters, [FromQuery] string q, [FromQuery] int teamId)
        {
            return Ok(await _playerService.GetAllPlayersSortedByCountry(pageParameters, q, teamId));
        }
    }
}
