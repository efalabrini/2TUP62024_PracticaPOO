using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Ej3;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3Controller : ControllerBase
    {

        [HttpPost()]
        public IActionResult CrearPersona([FromQuery] string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                return BadRequest("El nombre no puede estar vacío.");
            }

            var persona = new Persona(nombre);
            return Ok(persona.Saludar());
        }

        
        [HttpPost()]
        public IActionResult CrearEstudiante([FromQuery] string nombre, [FromQuery] int edad)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                return BadRequest("El nombre no puede estar vacío.");
            }

            if (edad <= 0)
            {
                return BadRequest("La edad debe ser un número positivo.");
            }

            var estudiante = new Estudiante(nombre);
            estudiante.SetEdad(edad);
            return Ok(new { Saludo = estudiante.Saludar(), Edad = estudiante.MostrarEdad() });
        }

        
        [HttpPost()]
        public IActionResult CrearProfesor([FromQuery] string nombre, [FromQuery] int edad)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                return BadRequest("El nombre no puede estar vacío.");
            }

            if (edad <= 0)
            {
                return BadRequest("La edad debe ser un número positivo.");
            }

            var profesor = new Profesor(nombre);
            profesor.SetEdad(edad);
            return Ok(new { Saludo = profesor.Saludar(), Explicacion = profesor.Explicar() });
        }
    }
}
}
