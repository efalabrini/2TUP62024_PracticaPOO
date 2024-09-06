using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using Web.Ej1;

namespace Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Ej1Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] string name1, string name2, string name3)
        {

            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona(name1));
            personas.Add(new Persona(name2));
            personas.Add(new Persona(name3));


            List<string> saludos = [];

            foreach (Persona persona in personas)
            {
                saludos.Add(persona.GetSaludo());
            }

            return Ok(saludos);
        }

        
    }
}
