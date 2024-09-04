using Microsoft.AspNetCore.Mvc;
using Web.Ej5;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class Ej5Controller : ControllerBase
{
    static List<Personaje> listaPersonajes = new List<Personaje>();
    static List<Enemigo> listaEnemigos = new List<Enemigo>();

    [HttpPost("Fuerza")]
    public ActionResult Fuerza(string nombre, int agilidad, int magia)
    {
        var personajeFuerza = new PersonajeDeFuerza(nombre, agilidad, magia);
        listaPersonajes.Add(personajeFuerza);
        return Ok(listaPersonajes);
    }

    [HttpPost("Agilidad")]

    public ActionResult Agilidad(string nombre, int fuerza, int agilidad, int magia)
    {
        var personajeAgilidad = new PersonajeDeAgilidad(nombre, fuerza, agilidad, magia);
        listaPersonajes.Add(personajeAgilidad);
        return Ok(listaPersonajes);
    }

    [HttpPost("Magia")]
    public ActionResult Magia(string nombre, int fuerza, int agilidad)
    {
        var personajeMagia = new PersonajeDeMagia(nombre, fuerza, agilidad);
        listaPersonajes.Add(personajeMagia);
        return Ok(listaPersonajes);
    }

    [HttpPost("Enemigo")]
    public ActionResult Enemigo(int vida, int nivel)
    {
        var enemigo = new Enemigo(vida, nivel);
        listaEnemigos.Add(enemigo);
        return Ok(listaEnemigos);
    }

    [HttpGet("Batalla")]
    public IActionResult Batalla()
    {
        Turno.Atacarse(listaPersonajes);
        Turno.MoverFichas(listaEnemigos[0], 10, 5, "derecha", "arriba");
        Turno.MoverFichas(listaPersonajes[2], 8, 12, "izquierda", "abajo");
        Turno.Atacarse(listaPersonajes);

        return Ok("Se atacaron todos");
    }

}