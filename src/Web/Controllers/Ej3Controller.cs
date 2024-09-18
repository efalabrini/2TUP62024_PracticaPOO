using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Web.Ej3;
namespace Web.Controllers;
[ApiController]
[Route("[controller]")]
public class Ej3Controller: ControllerBase
{
    [HttpPost("crear-persona")]
    public IActionResult CrearPersona([FromQuery] string nombre) 
    {
        var persona= new Persona(nombre);
        return Ok(persona.Saludar());
    }

    [HttpPost("crear-estudiante")]
    public IActionResult CrearEstudiante([FromQuery] string nombre, [FromQuery] int edad) 
    {
        var estudiante= new Estudiante(nombre);
        estudiante.SetEdad(edad);
        var saludo= estudiante.Saludar();
        var mostrarEdad= estudiante.MostrarEdad();
        return Ok(new { Saludo = saludo, Edad = mostrarEdad });
    }

    [HttpPost("crear-profe")]
    public IActionResult CrearProfe([FromQuery] string nombre, [FromQuery] int edad) 
    {
        var profesor= new Profesor(nombre);
        profesor.SetEdad(edad);
        var saludo=profesor.Saludar();
        var explicacion=profesor.Explicar();
        return Ok(new {Saludo=saludo, Explicacion= explicacion});

    }
}
