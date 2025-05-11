using System.Reflection;
using ApiCountries_Adapters.CountryAdapter;
using ApiCountries_Models;
using CountriesService;
using Microsoft.AspNetCore.Mvc;

namespace ApiCountries_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly CountryAdapter _countryAdp = new();

        [HttpGet]
        public IActionResult ReadAll() => Ok(_countryAdp.ReadAll());

        [HttpPost]
        public IActionResult Create(Country model)
        {
            return Ok(_countryAdp.Create(model));
        }

        [HttpPut]
        public IActionResult Update([FromBody] Country model)
        {
            return Ok(_countryAdp.Update(model));
        }

        [HttpDelete("{id}")]
        public IActionResult  Delete(short id)
        {
            return Ok(_countryAdp.Delete(id));
        }

    }
}
