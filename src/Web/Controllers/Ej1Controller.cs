using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Ej1;
using System.Collections.Generic;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej1Controller : Controller
    {
        [HttpGet("[action]")]
        public ActionResult<string[]> GetSaludos([FromQuery] string name1, string name2, string name3)
        {
            var list = new List<Person>
            {
                new Person(name1),
                new Person(name2),
                new Person(name3),
            };

            var saludos = new List<string>();

            list.ForEach(person => { saludos.Add(person.Saludo()); });

            return Ok(saludos.ToArray());
        }
    }
}