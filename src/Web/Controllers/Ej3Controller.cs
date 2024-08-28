using Microsoft.AspNetCore.Mvc;
using Web.Ej3;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej3Controller : ControllerBase
{
    [HttpPost("CreatePerson")]
    public IActionResult CreatePerson([FromQuery] string Nombre)
    {
        if (Nombre == null)
        {
            return BadRequest("Debe ingresar un nombre");
        }
        else
        {
            Persona persona = new Persona
            {
                Nombre = Nombre
            };
            return Ok(persona.Saludar());
        }
    }

    [HttpPost("createStudent")]
    public IActionResult CreateStudent([FromQuery] string Nombre, [FromQuery] int edad)
    {
        if (Nombre == null)
        {
            return BadRequest("Debe ingresar un nombre");
        }
        if (edad <= 0)
        {
            return BadRequest("Debe ingresar una edad mayor a 0");
        }

        Estudiante persona = new Estudiante
        {
            Nombre = Nombre
        };
        persona.SetEdad(edad);
        return Ok(persona.Saludar() + ". " + persona.MostrarEdad());
    }

    [HttpPost("createProfessor")]
    public IActionResult CreateProfessor([FromQuery] string Nombre, [FromQuery] int edad)
    {
        if (Nombre == null)
        {
            return BadRequest("Debe ingresar un nombre");
        }
        if (edad <= 0)
        {
            return BadRequest("Debe ingresar una edad mayor a 0");
        }

        Profesor profesor = new Profesor
        {
            Nombre = Nombre
        };
        profesor.SetEdad(edad);
        return Ok(profesor.Saludar() + ". " + profesor.Explicar());

    }
}

