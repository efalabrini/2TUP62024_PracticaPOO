using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Web.Controllers.Ejercicio05;

[ApiController]
[Route("api/[controller]")]
public class Ej5Controller : ControllerBase
{
    static List<Personaje> listaPersonajes = new List<Personaje>();
    static List<Enemigo> listaEnemigos = new List<Enemigo>();

    [HttpPost("crearPersonajeDeFuerza")]
    public IActionResult CrearPersonajeDeFuerza(string nombre, int agilidad, int magia)
    {
        var personaje = new PersonajeDeFuerza(nombre, agilidad, magia);
        listaPersonajes.Add(personaje);
        return Ok(personaje);
    }

    [HttpPost("crearPersonajeDeAgilidad")]
    public IActionResult CrearPersonajeDeAgilidad(string nombre, int fuerza, int agilidad, int magia)
    {
        var personaje = new PersonajeDeAgilidad(nombre, fuerza, agilidad, magia);
        listaPersonajes.Add(personaje);
        return Ok(personaje);
    }

    [HttpPost("crearPersonajeDeMagia")]
    public IActionResult CrearPersonajeDeMagia(string nombre, int fuerza, int agilidad, int magia = 60)
    {
        var personaje = new PersonajeDeMagia(nombre, fuerza, agilidad, magia);
        listaPersonajes.Add(personaje);
        return Ok(personaje);
    }

    [HttpPost("crearEnemigo")]
    public IActionResult CrearEnemigo(int vida, int nivel)
    {
        var enemigo = new Enemigo(vida, nivel);
        listaEnemigos.Add(enemigo);
        return Ok(enemigo);
    }

    [HttpGet("batalla")]
    public IActionResult Batalla()
    {
        var resultadoBatalla = "La batalla comenzó:\n";

        foreach (var personaje in listaPersonajes)
        {
            resultadoBatalla += personaje.Atacar() + "\n";
        }

        foreach (var enemigo in listaEnemigos)
        {
            
            resultadoBatalla += $"El enemigo con nivel {enemigo.Nivel} y vida {enemigo.Vida} está en la batalla.\n";
        }

        return Ok(resultadoBatalla);
    }
}
