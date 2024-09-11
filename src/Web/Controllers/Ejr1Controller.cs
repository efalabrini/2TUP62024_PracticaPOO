using Microsoft.AspNetCore.Mvc;
using Web.Ejr1;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ejr1Controller : ControllerBase
    {
       
        [HttpGet]
        public ActionResult <List<string>> Get([FromQuery]List<string> names) 
        {
            var saludos = new List<string>();

            foreach (var name in names)
            {
                var person = new Person(name);
                saludos.Add(person.GetSaludo());
                
            }
            return saludos;

        }

    }
}
