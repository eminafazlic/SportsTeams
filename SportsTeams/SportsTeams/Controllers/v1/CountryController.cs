using Microsoft.AspNetCore.Mvc;
using SportsTeams.Model;
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
    public class CountryController : ControllerBase
    {
        public ICountryService _countryService { get; set; }

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]CountryParameters countryParameters)
        {
            return Ok(await _countryService.Get(countryParameters));
        }
        [HttpGet(template: "{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var item = await _countryService.GetById(id);
            if(item==null)
            {
                return NotFound();
            }
            return Ok(item);
        }
        [HttpPost]
        public async Task<IActionResult> Insert(Country country)
        {
            if (country == null)
            {
                return BadRequest();
            }
            await _countryService.Insert(country);
            return CreatedAtRoute("GetCountries", new { Controller = "Country", id = country.Id }, country);
        }
        [HttpPut(template:"{id}")]
        public Country Update(int id, Country country)
        {
            return _countryService.Update(id, country);
        }
    }
    
}