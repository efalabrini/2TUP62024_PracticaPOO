using System;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class Ej3Controller : ControllerBase
{
    private static List<Persona> personas = new List<Persona>();

    [HttpPost("crearPersona")]
    public ActionResult CrearPersona([FromQuery] string nombre)
    {
        var persona = new Persona { Nombre = nombre};
        personas.Add(persona);
        return Ok(persona.Saludar());
    }

    [HttpPost("crearEstudiante")]
     public ActionResult CrearEstudiante([FromQuery] string nombre,[FromQuery] int edad)
    {
        var estudiante = new Estudiante { Nombre = nombre};
        estudiante.SetEdad(edad);
        personas.Add(estudiante);
        return Ok(new {Saludo = estudiante.Saludar(), Edad = estudiante.MostrarEdad(), Estudio = estudiante.Estudiar()});
    }

    [HttpPost("crearProfesor")]
     public ActionResult CrearProfesor([FromQuery] string nombre,[FromQuery] int edad)
    {
        var profesor= new Profesor { Nombre = nombre};
        profesor.SetEdad(edad);
        personas.Add(profesor);
        return Ok(new {Saludo = profesor.Saludar(), Edad = profesor.MostrarEdad(), Explicar = profesor.Explicar()});
    }

}
