using System;
using Microsoft.AspNetCore.Mvc;
using Web.Ej1;
namespace Web.Controllers;
[ApiController]
[Route("[controller]")]
public class Ej1Controller : ControllerBase
{
    [HttpGet("[Action]")]
    public ActionResult<string []> GetSaludos([FromQuery] string nombre1, string nombre2, string nombre3)
    {
            var persona1 = new Persona { Nombre = nombre1 };
            var persona2 = new Persona { Nombre = nombre2 };
            var persona3 = new Persona { Nombre = nombre3 };

            var saludos = new string[]
            {
                persona1.GetSaludo(),
                persona2.GetSaludo(),
                persona3.GetSaludo()
            };
 
            return Ok(saludos);
    }
}
