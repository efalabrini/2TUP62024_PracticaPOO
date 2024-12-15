using Microsoft.AspNetCore.Mvc;
using Web.Ej4;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej4Controller : Controller
    {
        [HttpPost("crearYConducir")]
        public IActionResult CrearYConducir([FromQuery] int combustibleInicial)
        {
            var coche = new Coche(combustibleInicial);
            coche.Conducir();

            string mensaje = combustibleInicial > 0 ? "El coche está siendo manejado" : "El coche no tiene combustible";
            return Ok(mensaje);
        }

        [HttpPost("cargarYConducir")]
        public IActionResult CargarYConducir([FromQuery] int cantidadCombustible)
        {
            var coche = new Coche(0);  
            coche.CargarCombustible(cantidadCombustible);  
            coche.Conducir();  

            string mensaje = cantidadCombustible > 0 ? "El coche está siendo manejado" : "El coche no tiene combustible";
            return Ok(mensaje);
        }
    }
}
