using Microsoft.AspNetCore.Mvc;
using Web.Ej1;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej1Controller : ControllerBase
    {

        [HttpGet]
        public ActionResult<List<string>> Get([FromQuery] List<string> names) {
            {
                var saludo = new List<string>();

                foreach (var name in names)
                {
                    var person = new Persona(name);
                    saludo.Add(person.GetSaludo(name));
                }

                return Ok(saludo);
            }
        }
    }
}