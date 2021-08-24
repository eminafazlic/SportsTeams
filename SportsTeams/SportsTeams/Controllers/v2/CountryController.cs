using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SportsTeams.Database;
using SportsTeams.Model;
using SportsTeams.Model.Requests;
using SportsTeams.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsTeams.Controllers.v2
{
    

    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("2")]
    [ApiExplorerSettings(GroupName = "v2")]
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
        public async Task<IActionResult> GetAllCountries([FromQuery]PageParameters pageParameters)
        {
            _logger.LogInformation($"Izvršava se {nameof(GetAllCountries).ToString()} metoda sa parametrima {nameof(pageParameters.PageNumber).ToString()} i {nameof(pageParameters.PageSize).ToString()} i modelom {nameof(PageParameters).ToString()}");
            return Ok(await _countryService.GetAllCountries(pageParameters));
        }
    }
    
}