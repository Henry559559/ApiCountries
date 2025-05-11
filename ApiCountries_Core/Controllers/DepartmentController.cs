using ApiCountries_Adapters.DepartmentAdapter;
using CountriesService;
using Microsoft.AspNetCore.Mvc;

namespace ApiCountries_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly DepartmentAdapter _departmentAdp = new();

        [HttpGet]
        public IActionResult ReadAll() => Ok(_departmentAdp.ReadAll());

        [HttpPost]
        public IActionResult Create(Department model)
        {
            return Ok(_departmentAdp.Create(model));
        }

        [HttpPut]
        public IActionResult Update([FromBody] Department model)
        {
            return Ok(_departmentAdp.Update(model));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(short id)
        {
            return Ok(_departmentAdp.Delete(id));
        }
    }
}
