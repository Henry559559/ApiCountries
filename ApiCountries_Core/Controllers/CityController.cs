using ApiCountries_Adapters.CityAdapter;
using CountriesService;
using Microsoft.AspNetCore.Mvc;

namespace ApiCountries_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : Controller
    {
        private readonly CityAdapter _cityAdp = new();

        [HttpGet]
        public IActionResult ReadAll() => Ok(_cityAdp.ReadAll());

        [HttpPost]
        public IActionResult Create(City model)
        {
            return Ok(_cityAdp.Create(model));
        }
    }
}
