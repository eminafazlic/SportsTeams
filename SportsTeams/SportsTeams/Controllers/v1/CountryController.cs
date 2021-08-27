using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SportsTeams.Database;
using SportsTeams.Filters;
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
    public class CountryController : ControllerBase
    {
        public ICountryService _countryService { get; set; }

        public CountryController(ICountryService countryService, ILogger<CountryController> logger)
        {
            _countryService = countryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCountries([FromQuery] PageParameters pageParameters, [FromQuery] string q)
        {
            return Ok(await _countryService.GetAllCountries(pageParameters, q));
        }
        [HttpGet(template: "{id}")]
        public async Task<IActionResult> GetCountryById(int id)
        {
            return Ok(await _countryService.GetCountryById(id));

        }
        [HttpPost]
        public async Task<IActionResult> InsertCountry([FromBody] CountryInsertRequest request)
        { 
            return Created("~/api/v1/country", await _countryService.InsertCountry(request));

        }
        [HttpPut(template: "{id}")]
        public async Task<IActionResult> UpdateCountry(int id, CountryUpdateRequest request)
        {
            return Ok(await _countryService.UpdateCountry(id, request));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCountry(int id)
        {
            await _countryService.DeleteCountry(id);
            return NoContent();
        }
    }
    
}