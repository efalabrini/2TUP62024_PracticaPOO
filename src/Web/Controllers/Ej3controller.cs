using Microsoft.AspNetCore.Mvc;
using Web.Ej3;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej3controller : ControllerBase
    {
        [HttpGet("CreatePerson")]
        public IActionResult CreatePerson(string nombre)
        {
            if (nombre == null)
            {
                string result = "Ingrese un nombre";
                return BadRequest(result);
            }

            Persona persona = new Persona
            {
                Nombre = nombre
            };

            return Ok(persona.Saludar());

        }

        [HttpGet("CreateStudent")]
        public IActionResult CreateStudent(int edad, string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                return BadRequest("Ingrese un nombre");
            }

            if (edad <= 0)
            {
                return BadRequest("Ingrese una edad positiva o mayor a 0");
            }

            var estudiante = new Estudiante 
            { 
                Nombre = nombre
            };
            estudiante.SetEdad(edad);
            var saludo = estudiante.Saludar() + ", " + estudiante.MostrarEdad();

            return Ok(saludo);
        }


        [HttpGet("CreateProfesor")]
        public IActionResult CreateProfesor(string nombre, int edad) 
        {
            if (string.IsNullOrEmpty(nombre)) 
            {
                return BadRequest("Ingrese un nombre");
            }

            if (edad <= 0)
            {
                return BadRequest("Ingrese una edad positiva o mayor a 0");
            }

            var profesor = new Profesor 
            { 
                Nombre = nombre 
            };

            profesor.SetEdad(edad);
            var saludo = profesor.Saludar() + ", " + profesor.Explicando();

            return Ok(saludo);
        }
    }
}
