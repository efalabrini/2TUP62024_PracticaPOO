using Microsoft.AspNetCore.Mvc;
using Web.Ej4;

namespace Web.Controllers;
[ApiController]
[Route("[controller]")]

public class Ej4Controller : Controller         
{
    [HttpPost("nuevoCoche")]
    public IActionResult nuevoCoche(int combustibleInicial)
    {
        Coche coche = new Coche(combustibleInicial);
        return Ok(coche.Conducir());
    }

    [HttpPost("cargarCombustible")]
    public IActionResult cargarCombustible(int cantidadCombustible)
    {
        Coche coche = new Coche(0);
        coche.CargarCombustible(cantidadCombustible);
        return Ok(coche.Conducir());    
    }
}