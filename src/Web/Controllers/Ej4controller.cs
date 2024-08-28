using Microsoft.AspNetCore.Mvc;
using Web.Ej4;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej4controller : ControllerBase
    {
        [HttpGet("CrearYConducir")]
        public IActionResult CrearYConducir(int cant_combustible)
        {
            Coche auto = new Coche(cant_combustible);

            return Ok(auto.Conducir());
        }

        [HttpGet("CrearCargarConducir")]
        public IActionResult CrearCargarConducir(int cant_combustible)
        {
            Coche auto = new Coche(0);

            auto.CargarCombustible(cant_combustible);

            return Ok(auto.Conducir());

        }
    }
}
