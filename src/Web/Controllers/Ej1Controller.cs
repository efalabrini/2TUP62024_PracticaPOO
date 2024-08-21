using Microsoft.AspNetCore.Mvc;
using Web.Ej1;
using System.Collections.Generic;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej1Controller : ControllerBase
    {
        [HttpGet("Nombres")]
        public IActionResult GetNombres()
        {
            var personas = new List<Persona>
            {
                new Persona { Nombre = "Juan" },
                new Persona { Nombre = "María" },
                new Persona { Nombre = "Carlos" }
            };

            var nombres = new List<string>();
            foreach (var persona in personas)
            {
                nombres.Add(persona.Nombre);
            }

            return Ok(nombres);
        }

        [HttpGet("Saludos")]
        public IActionResult GetSaludos([FromQuery] List<string> nombres)
        {
            var saludos = new List<string>();

            for (int i = 0; i < nombres.Count; i++)
            {
                var persona = new Persona { Nombre = nombres[i] };
                saludos.Add(persona.GetSaludo());
            }

            return Ok(saludos);
        }
    }
}
