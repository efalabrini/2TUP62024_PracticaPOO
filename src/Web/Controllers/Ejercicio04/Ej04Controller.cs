using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Web.Controllers.Ejercicio04
{
    [ApiController]
    [Route("api/[controller]")]
    public class CocheController : ControllerBase
    {
        [HttpPost("conducir/{combustibleInicial}")]
        public IActionResult ConducirCoche(int combustibleInicial)
        {
            Coche coche = new Coche(combustibleInicial);
            coche.Conducir(); 
            return Ok(coche.Mensaje); 
        }

        [HttpPost("cargarCombustible/{cantidad}")]
        public IActionResult CargarCombustibleYConducir(int cantidad)
        {
            Coche coche = new Coche(0);  
            coche.CargarCombustible(cantidad); 
            coche.Conducir(); 
            return Ok(coche.Mensaje); 
        }
    }
}
