using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Ej1;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej1Controller : ControllerBase
    {
        [HttpGet()]
        public List<string> Get([FromQuery] string persona1, [FromQuery] string persona2, [FromQuery] string persona3)
        {
            List<Persona> lista = [];
            lista.Add(new Persona(persona1));
            lista.Add(new Persona(persona2));
            lista.Add(new Persona(persona3));

            List<string> result = [];

            foreach (Persona persona in lista)
            {
                result.Add(persona.GetSaludo());
            }

            return result;
        }
    }
}
