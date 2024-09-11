using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.Ejercicio01
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej01Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult Get(string nombre1, string nombre2, string nombre3)
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona(nombre1));
            personas.Add(new Persona(nombre2));
            personas.Add(new Persona(nombre3));

            List<string> saludos = new List<string>();

            foreach (Persona persona in personas)
            {
                saludos.Add(persona.GetSaludo());
            }

            return Ok(saludos);
        }

    }
}
