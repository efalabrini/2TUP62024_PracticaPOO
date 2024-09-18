using Microsoft.AspNetCore.Mvc;
using Web.Ej3;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej3Controller : ControllerBase
    {
        [HttpPost("crear-persona")]
        public ActionResult<string> CrearPersona([FromBody] Persona persona)
        {
            return persona.Saludar();  
        }

        [HttpPost("crear-estudiante")]
        public ActionResult<string> CrearEstudiante([FromBody] Estudiante estudiante)
        {
            estudiante.SetEdad(estudiante.edad);  
            string saludo = estudiante.Saludar();  
            string edad = estudiante.MostrarEdad();  
            return $"{saludo}\n{edad}";
        }

        [HttpPost("crear-profesor")]
        public ActionResult<string> CrearProfesor([FromBody] Profesor profesor)
        {
            profesor.SetEdad(profesor.edad);
            string saludo = profesor.Saludar();
            string explicar = profesor.Explicar();  
            return $"{saludo}\n{explicar}";
        }
    }
}

