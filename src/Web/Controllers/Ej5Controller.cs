using Microsoft.AspNetCore.Mvc;
using Web.Ej5;

using Microsoft.AspNetCore.Mvc;
using Web.Ej5;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class Ej5Controller : ControllerBase
{
    static List<Personaje> listaPersonajes = new List<Personaje>();
    static List<Enemigo> listaEnemigos = new List<Enemigo>();

    [HttpPost("ForceCharacter")]
    public ActionResult ForceCharacter(string name, int agility, int magic)
    {
        var personajeFuerza = new PersonajeDeFuerza(name, agility, magic);
        listaPersonajes.Add(personajeFuerza);
        return Ok(listaPersonajes);
    }

    [HttpPost("AgilityCharacter")]
    public ActionResult AgilityCharacter(string name, int force, int agility, int magic)
    {
        var personajeAgilidad = new PersonajeDeAgilidad(name, force, agility, magic);
        listaPersonajes.Add(personajeAgilidad);
        return Ok(listaPersonajes);
    }

    [HttpPost("MagicCharacter")]
    public ActionResult MagicCharacter(string name, int force, int agility )
    {
        var personajeMagia = new PersonajeDeMagia(name, force, agility);
        listaPersonajes.Add(personajeMagia);
        return Ok(listaPersonajes);
    }

    [HttpPost("Enemy")]
    public ActionResult Enemy(int life, int level)
    {
        var enemigo = new Enemigo(life, level);
        listaEnemigos.Add(enemigo);
        return Ok(listaEnemigos);
    }

    [HttpGet("Batle")]
    public IActionResult Battke()
    {
        if (listaPersonajes.Count() != 0) { 
        Turno.Atacarse(listaPersonajes);
        Turno.MoverFichas(listaEnemigos[0], 13, 34, "derecha", "arriba");
        Turno.MoverFichas(listaPersonajes[2], 8, 12, "izquierda", "arriba");
        Turno.MoverFichas(listaPersonajes[1], 7, 4, "izquierda", "abajo");
        Turno.MoverFichas(listaPersonajes[0], 1, 18, "derecha", "abajo");
        Turno.Atacarse(listaPersonajes);

        return Ok("Batalla finalizada.");
        }

        return Ok("No hay personajes para realizar la batalla.");
    }

}
