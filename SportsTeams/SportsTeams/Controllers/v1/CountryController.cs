using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SportsTeams.Database;
using SportsTeams.Filters;
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

    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1")]
    [ApiExplorerSettings(GroupName = "v1")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        public ICountryService _countryService { get; set; }
        ILogger<CountryController> _logger;

        public CountryController(ICountryService countryService, ILogger<CountryController> logger)
        {
            _countryService = countryService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCountries([FromQuery]CountryParameters countryParameters)
        {
            _logger.LogInformation($"Izvršava se {nameof(GetAllCountries).ToString()} metoda sa parametrima {nameof(countryParameters.PageNumber).ToString()} i {nameof(countryParameters.PageSize).ToString()} i modelom {nameof(CountryParameters).ToString()}");
            return Ok(await _countryService.GetAllCountries(countryParameters));
        }
        [HttpGet(template: "{id}")]
        public async Task<IActionResult> GetCountryById(int id)
        {
            return Ok(await _countryService.GetCountryById(id));
        }
        [HttpPost]
        public async Task<IActionResult> InsertCountry([FromBody] CountryInsertRequest request)
        {
            return Created("~/api/country", await _countryService.InsertCountry(request));   
        }
        [HttpPut(template: "{id}")]
        public async Task<IActionResult> UpdateCountry(int id, CountryUpdateRequest request)
        {
            return Ok(await _countryService.UpdateCountry(id, request));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCountry(int id)
        {
            try
            {
                await _countryService.DeleteCountry(id);
                return NoContent();
            }
            catch
            {
                return NotFound($"Država s ID-jem {id} nije pronađena");
            }
        }
    }
    
}