using Microsoft.AspNetCore.Mvc;
using Web.Ej4;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej4Controller : ControllerBase 
{

    [HttpPost("CrearCoche")]
    public IActionResult CrearCoche([FromForm] int combustible)
    {
        if(combustible < 0)
        {
            return BadRequest("No puede ingresar combustible negativo");
        }

        Coche coche = new Coche(combustible);
        return Ok(coche.Conducir());
    }

    [HttpPost("CrearOtroCoche")]
    public IActionResult CrearOtroCoche([FromForm] int combustible)
    {
        if (combustible < 0)
        {
            return BadRequest("No puede ingresar combustible negativo");
        }

        Coche coche = new Coche(0);
        coche.CargarCombustible(combustible);
        return Ok(coche.Conducir() + " Le cargó " + combustible + " litros.");
    }
}