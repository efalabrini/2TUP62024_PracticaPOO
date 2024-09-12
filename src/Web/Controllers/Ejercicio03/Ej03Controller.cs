using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class PersonasController : ControllerBase
{
    [HttpPost("crear-persona")]
    public IActionResult CrearPersona([FromQuery] string nombre)  
    {
        var persona = new Persona(nombre);
        return Ok(persona.Saludar());
    }

    [HttpPost("crear-estudiante")]
    public IActionResult CrearEstudiante([FromQuery] string nombre, [FromQuery] int edad)  
    {
        var estudiante = new Estudiante(nombre);
        estudiante.SetEdad(edad);
        var saludo = estudiante.Saludar();
        var edadMensaje = estudiante.MostrarEdad();
        return Ok(new { saludo, edadMensaje });
    }

    [HttpPost("crear-profesor")]
    public IActionResult CrearProfesor([FromQuery] string nombre, [FromQuery] int edad)  
    {
        var profesor = new Profesor(nombre);
        profesor.SetEdad(edad);
        var saludo = profesor.Saludar();
        var explicacion = profesor.Explicar();
        return Ok(new { saludo, explicacion });
    }

}
