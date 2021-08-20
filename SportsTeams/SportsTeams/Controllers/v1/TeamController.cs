using Microsoft.AspNetCore.Mvc;
using SportsTeams.Database;
using SportsTeams.Model;
using SportsTeams.Model.Requests;
using SportsTeams.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsTeams.Controllers.v1
{
    /*[ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]*/

    [ApiController]
    [Route("[controller]")]
    public class TeamController : ControllerBase
    {
        public ITeamService _teamService { get; set; }

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]CountryParameters countryParameters)
        {
            return Ok(await _teamService.Get(countryParameters));
        }

        [HttpGet(template: "{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var item = await _teamService.GetById(id);
            if(item==null)
            {
                return NotFound();
            }
            return Ok(item);
        }
        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] TeamInsertRequest request)
        {
            return Created("~/api/team", await _teamService.Insert(request));
        }
        [HttpPut(template: "{id}")]
        public async Task<IActionResult> Update(int id, TeamUpdateRequest request)
        {
            if (request == null)
            {
                return BadRequest();
            }
            await _teamService.Update(id, request);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _teamService.Delete(id);
            return NoContent();
        }
    }
    
}