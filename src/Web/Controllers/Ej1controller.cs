using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonaController : ControllerBase
{
    private static readonly List<Persona> personas = new List<Persona>
    {
        new Persona("Juan"),
        new Persona("Maria"),
        new Persona("Carlos")
    };


    [HttpGet]
    public ActionResult<List<string>> GetSaludo()
    {
        var nombres = Persona.ObtenerNombres(personas);
        var saludos = nombres.Select(nombres => new Persona(nombres).GetSaludo()).ToList();
        return Ok(saludos);
    }

}
