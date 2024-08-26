using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Web.Ej3;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3Controller : ControllerBase
    {
        [HttpPost("CreatePerson")]
        public IActionResult Create([FromQuery] string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                var persona = new Persona(name);
                return Ok(persona.Saludar());
            }
            else { return BadRequest(); }

        }

        [HttpPost("createStudent")]
        public IActionResult CreateStudent([FromQuery] string name, int edad)
        {
            if (!string.IsNullOrEmpty(name) && edad > 0)
            {
                var estudiante = new Estudiante(name);

                estudiante.SetEdad(edad);

                var formattedOutput = new
                {
                    saludo = estudiante.Saludar(),
                    edad = estudiante.MostrarEdad(),
                    Estudio = estudiante.Estudiar()
                };

                return Ok(formattedOutput);

            }
            else { return BadRequest(); }
        }

        [HttpPost("CreateProfessor")]
        public IActionResult CreatProfessor([FromQuery] string name, int edad)
        {
            if (!string.IsNullOrEmpty(name) && edad > 0)
            {
                var profesor = new Profesor(name);

                profesor.SetEdad(edad);

                var formattedOutput = new
                {
                    saludo = profesor.Saludar(),
                    Estudio = profesor.Explicar()
                };

                return Ok(formattedOutput);

            }
            else { return BadRequest(); }
        }
    }
}

