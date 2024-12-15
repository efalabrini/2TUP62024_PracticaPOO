using Microsoft.AspNetCore.Mvc;
using Web.Ej3;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej3Controller : Controller
    {
        [HttpGet("SaludoPersona")]
        public IActionResult GetSaludo()
        {
            var persona = new Persona("Jorge");

            return Ok(persona.Saludar());
        }

        [HttpGet("SaludoEstudiante")]
        public ActionResult<EstudianteDto> GetSaludoEstudiante([FromQuery] string name, int edad)
        {
            var estudiante = new Estudiante(name);
            estudiante.SetEdad(edad);
            var saludoEstudiante = estudiante.Saludar();

            var response = new EstudianteDto
            {
                Nombre = estudiante.Nombre,
                Edad = estudiante.Edad,
                Saludo = saludoEstudiante
            };

            return Ok(response);
        }

        [HttpGet("SaludoCompletoProfesor")]
        public ActionResult<ProfesorDto> GetSaludoProfesor([FromQuery] string name, int edad)
        {
            var profesor = new Profesor(name);
            profesor.SetEdad(edad);
            string saludo = profesor.Saludar();
            string explicar = profesor.Explicar();

            var response = new ProfesorDto
            {
                Nombre = profesor.Nombre,
                Edad = profesor.Edad,
                Saludo = saludo,
                Explicar = explicar
            };

            return Ok(response);
        }

    }
}

