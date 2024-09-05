using Microsoft.AspNetCore.Mvc;
using Web.Ej3;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3Controller : ControllerBase 
    {
        [HttpGet("SaludarP")]
        public IActionResult GetSaludo() 
        {
            var persona = new Persona("Dilan");

            return Ok(persona.Saludar());
        }

        [HttpGet("SaludarEst")]
        public ActionResult<Estudiante> GetSaludarEstudiante([FromQuery] string name, int edad) 
        {
            var estudiante = new Estudiante(name);
            estudiante.setEdad(edad);

            var saludarEstudiante = estudiante.Saludar();
            var edadEstudiante = estudiante.MostrarEdad();

            return Ok($"{saludarEstudiante}, {edadEstudiante}");
        }

        [HttpGet("SaludarProfe")]
        public ActionResult<Profesor> GetSaludarProfesor([FromQuery] string name, int edad)
        {
            var profesor = new Profesor(name);
            profesor.setEdad(edad);

            var saludarProfesor = profesor.Saludar();
            var explicacionProfesor = profesor.Explicar();

            return Ok($"{saludarProfesor}, {explicacionProfesor}, {edad}");

        }
    }
}
