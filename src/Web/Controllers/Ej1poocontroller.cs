using Microsoft.AspNetCore.Mvc;
using Web.Ej1poo;

namespace Web.Controllers;
/// <summary>
/// Crear un endpoint que reciba tres nombres de personas y retorne una lista con el saludo de cada persona.
/// Para ello, crear una clase Persona que tenga una propiedad Nombre de tipo string. 
/// Además la clase debe tener un método llamado GetSaludo, devuelva el siguiente resultado: 
/// "Hola! mi nombre es {Nombre}.".
/// </summary>
[ApiController]
[Route("[controller]/[Action]")]
public class Ej1pooController : ControllerBase
{
    [HttpGet]
    public IActionResult Greetings(string name1, string name2, string name3)
    {
        List<Persona> names = [];
        names.Add(new Persona(name1));
        names.Add(new Persona(name2));
        names.Add(new Persona(name3));

        List<string> greetings =[];
        foreach (Persona name in names)
        {
            greetings.Add(name.GetSaludo());
        }
        return Ok(greetings);
    }
}