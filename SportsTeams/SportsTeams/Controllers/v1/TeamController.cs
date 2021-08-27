using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SportsTeams.Database;
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
    public class TeamController : ControllerBase
    {
        public ITeamService _teamService { get; set; }
        ILogger<TeamController> _logger;

        public TeamController(ITeamService teamService, ILogger<TeamController> logger)
        {
            _teamService = teamService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTeams([FromQuery] PageParameters pageParameters, [FromQuery] string q)
        {
            return Ok(await _teamService.GetAllTeams(pageParameters, q));
        }

        [HttpGet(template: "{id}")]
        public async Task<IActionResult> GetTeamById(int id)
        {
            return Ok(await _teamService.GetTeamById(id));
        }
        [HttpGet(template: "countryid={countryId}")]
        public async Task<IActionResult> GetTeamsByCountryId([FromQuery] PageParameters pageParameters, int countryId)
        {
            return Ok(await _teamService.GetTeamsByCountryId(pageParameters, countryId));
        }
        [HttpPost]
        public async Task<IActionResult> InsertTeam([FromBody] TeamInsertRequest request)
        {
            return Created("~/api/v1/team", await _teamService.InsertTeam(request));
        }
        [HttpPut(template: "{id}")]
        public async Task<IActionResult> UpdateTeam(int id, TeamUpdateRequest request)
        {
            return Ok(await _teamService.UpdateTeam(id, request));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeam(int id)
        {
            await _teamService.DeleteTeam(id);
            return NoContent();
        }
    }
    
}