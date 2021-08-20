﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SportsTeams.Database;
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
        public async Task<IActionResult> Get([FromQuery]CountryParameters countryParameters)
        {
            _logger.LogInformation($"Izvršava se {nameof(Get).ToString()} metoda sa parametrima {nameof(countryParameters.PageNumber).ToString()} i {nameof(countryParameters.PageSize).ToString()} i modelom {nameof(CountryParameters).ToString()}");
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
        public async Task<IActionResult> Insert([FromBody] CountryInsertRequest request)
        {
            return Created("~/api/country", await _countryService.Insert(request));   
        }
        [HttpPut(template: "{id}")]
        public async Task<IActionResult> Update(int id, CountryUpdateRequest request)
        {
            return Ok(await _countryService.Update(id, request));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _countryService.Delete(id);
            return NoContent();
        }
    }
    
}