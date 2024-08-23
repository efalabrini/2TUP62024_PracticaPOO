using Microsoft.AspNetCore.Mvc;
using Web.Ej3;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej3Controller : ControllerBase
{
    [HttpPost("CreatePerson")]
    public IActionResult CreatePerson([FromQuery] string Nombre){
        if(Nombre == null){
            return BadRequest("Debe ingresar un nombre");
        } else {
        Persona persona = new Persona{
            Nombre = Nombre
        };
        return Ok("Persona creada: " + persona.Saludar());
        }
    }

    [HttpPost("createStudent")]
    public IActionResult CreateStudent([FromQuery] string Nombre, [FromQuery] int edad)
    {
        
    }
}

