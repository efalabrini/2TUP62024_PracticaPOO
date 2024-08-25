using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Web.Ej1;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej1Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<string>> Get([FromQuery] List<string> namesList)
        {
            if (namesList.Count != 3 || namesList == null)
            {
                return BadRequest("you have to enter exactly 3 names!");
            }
            //Crear un endpoint que reciba tres nombres de personas y retorne una lista con el saludo de cada persona.
            //Para ello, crear una clase Persona que tenga una propiedad Nombre de tipo string.
            //Además la clase debe tener un método llamado GetSaludo, devuelva el siguiente resultado: "Hola! mi nombre es {Nombre}.".

            var greeting = new List<string>();

            foreach (var name in namesList)
            {
                var person = new Persona(name);
                greeting.Add(person.GetGreeting(name));
            }


            return Ok(greeting);
        }
    }
}
