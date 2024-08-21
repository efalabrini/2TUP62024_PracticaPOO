using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Ej1;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej1Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult <List<string>> GetNames([FromQuery] string name1, string name2, string name3)
        {
          var listNames = new List<Person>()
          {
              new(name1),
              new(name2),
              new(name3)
          };

            var listSaludos = new List<string>();

            foreach (var person in listNames)
            {
                listSaludos.Add(person.Saludo());
            }

            return listSaludos;
        }
        
    }
}
