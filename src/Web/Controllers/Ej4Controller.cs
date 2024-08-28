using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Ej4;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4Controller : ControllerBase
    {
        [HttpPost("CrearAuto")]
        public IActionResult AddCar([FromQuery]int combustible)
        {
            if (combustible < 0) 
            {
                return BadRequest("No se puede ingresar un valor negativo");
            }
            Coche coche = new(combustible);
            return Ok(coche.Conducir());
        }

        [HttpPost("CrearNuevoAuto")]
        public IActionResult AddNewCar(int combustible)
        {
            Coche coche = new(0);
            coche.CargarCombustible(combustible);
            return Ok(coche.Conducir());
        }

    }
}
