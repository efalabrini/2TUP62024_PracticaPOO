using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Web.Ej1;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej1Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get(string nombre1, string nombre2, string nombre3)
    {
        List<Persona> personas = [];
        personas.Add(new Persona(nombre1));
        personas.Add(new Persona(nombre2));
        personas.Add(new Persona(nombre3));

        List<string> saludos = [];

        foreach (Persona persona in personas)
        {
            saludos.Add(persona.GetSaludo());
        }

        return Ok(saludos);
    }
}
