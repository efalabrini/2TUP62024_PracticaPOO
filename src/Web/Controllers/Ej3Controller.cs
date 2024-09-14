using Microsoft.AspNetCore.Mvc;
using Web.Ej3;

namespace Web.Controllers;
[ApiController]
[Route("[controller]")]

public class Ej3Controller : Controller
{
    [HttpPost("createNewPerson")]
    public IActionResult CreateNewPerson()
    {
        Persona persona = new Persona();
        return Ok(persona.Saludar());
    }

    [HttpPost("createNewStudent")]
    public IActionResult createNewStudent(int edad, string nombre)
    {
        if(edad > 0 && nombre.Length > 1)
        {
            Estudiante estudiante = new Estudiante(edad, nombre);
            return Ok($"{estudiante.Saludar()}, {estudiante.MostrarEdad()}");
        } else
        {
            return BadRequest("Edad o nombre no válidos");
        }
    }

    [HttpPost("createNewTeacher")]
    public IActionResult createNewTeacher(int edad, string nombre)
    {
        if (edad > 0 && nombre.Length > 1) { 
            Profesor profesor = new Profesor(edad, nombre);
            return Ok($"{profesor.Saludar()}, {profesor.Explicar()}");
        } else
        {
            return BadRequest("Edad o nombre no válidos");
        }
    }
}


