using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Ej3;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3Controller : ControllerBase
    {
        [HttpPost("[Action]")]
        public IActionResult AddPersona([FromQuery] string nombre)
        {
            var persona = new Persona { Nombre = nombre };
            return Ok(persona.Saludar());
        }

        [HttpPost("[Action]")]
        public IActionResult AddEstudiante([FromQuery] string nombre, [FromQuery] int edad)
        {
            var estudiante = new Estudiante { Nombre = nombre };
            estudiante.SetEdad(edad);

            var saludo = estudiante.Saludar() + ", " + estudiante.MostrarEdad();

            return Ok(saludo);  
   
        }

        [HttpPost("[Action]")]
        public IActionResult AddProfesor([FromQuery] string nombre)
        {
            var profesor = new Profesor {  Nombre = nombre };

            var saludo = profesor.Saludar() + ", " + profesor.Explicar();

            return Ok(saludo);  
        }
    }
}
