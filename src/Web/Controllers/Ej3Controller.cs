using Microsoft.AspNetCore.Mvc;
using Web.Ej3;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej3Controller : ControllerBase
    {
        [HttpPost("CrearPersona")]
        public ActionResult<string> CrearPersona([FromQuery] string nombre)
        {
            var persona = new Persona(nombre);
            return Ok(persona.Saludar());
        }
        [HttpPost("CrearEstudiante")]
        public ActionResult<string> CrearEstudiante([FromQuery] string nombre, [FromQuery] int edad)
        {
            var estudiante = new Estudiante(nombre);
            estudiante.SetEdad(edad);

            var result = new List<string>
            {
                {estudiante.Saludar()},
                {estudiante.MostrarEdad()}
            };
            return Ok(result);
        }

        [HttpPost("CrearProfesor")]
        public ActionResult<string> CrearProfesor([FromQuery] string nombre, [FromQuery] int edad)
        {
            var profesor = new Profesor(nombre);
            profesor.SetEdad(edad);

            var result = new List<string>
            {
                {profesor.Saludar()},
                {profesor.Explicar()}
            };
            return Ok(result);
        }
    }
}
