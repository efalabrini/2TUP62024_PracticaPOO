using Microsoft.AspNetCore.Mvc;
using Web.Ej3;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej3Controller : Controller
    {
        [HttpPost("persona")]
        public IActionResult CrearPersona([FromQuery] string nombre)
        {
            var persona = new Persona(nombre);
            return Ok(persona.Saludar());
        }

        [HttpPost("estudiante")]
        public IActionResult CrearEstudiante([FromQuery] string nombre, [FromQuery] int edad)
        {
            var estudiante = new Estudiante(nombre);
            estudiante.SetEdad(edad);
            var saludo = estudiante.Saludar();
            var edadMensaje = estudiante.MostrarEdad();
            return Ok(new { Saludo = saludo, Edad = edadMensaje });
        }

        [HttpPost("profesor")]
        public IActionResult CrearProfesor([FromQuery] string nombre, [FromQuery] int edad)
        {
            var profesor = new Profesor(nombre);
            profesor.SetEdad(edad);
            var saludo = profesor.Saludar();
            var explicacion = profesor.Explicar();
            return Ok(new { Saludo = saludo, Explicacion = explicacion });
        }
    }
}