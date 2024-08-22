using Microsoft.AspNetCore.Mvc;
using Web.ej1;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class Ej1Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get(string nombre1, string nombre2, string nombre3)
    {
        List<Persona> persons = [];
        persons.Add(new Persona(nombre1));
        persons.Add(new Persona(nombre2));
        persons.Add(new Persona(nombre3));

        List<string> saludos = [];

        foreach(Persona person in persons)
        {
            saludos.Add(person.GetSaludo());
        }

        return Ok(saludos);
    }


}
