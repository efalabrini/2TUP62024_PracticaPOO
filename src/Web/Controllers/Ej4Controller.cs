using Microsoft.AspNetCore.Mvc;
using Web.Ej4;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej4Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult NewCar(int cantCombustible)
        {
            Coche coche = new Coche(cantCombustible);
            return Ok(coche.Conducir());
        }

        [HttpGet]
        public IActionResult NewCarFull(int combustible) 
        {
            Coche coche = new Coche(0);
            coche.CargarCombustible(combustible);
            return Ok(coche.Conducir());    
        }

    }
}
