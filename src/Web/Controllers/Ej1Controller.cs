using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.CarpetaPersona;

namespace Web.Controllers
{
    public class Ej1Controller : Controller
    {
        [HttpGet]
        public IActionResult Get(List<string> names)
        {
            List<string> result = new List<string>();
            List<Persona> people = new List<Persona>();

            foreach(string name in names)
            {
                people.Add(new Persona(name));
            }
            foreach (Persona person in people)
            {
                result.Add(person.getSaludo());
            }

            return Ok(result);
        }

    }
}
