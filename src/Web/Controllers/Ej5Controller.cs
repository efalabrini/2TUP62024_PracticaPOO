using Microsoft.AspNetCore.Mvc;
using Web.Ej5;
 

namespace Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class Ej5Controller : ControllerBase
{
    static readonly List<Personaje> listaPersonajes = new List<Personaje>();
    static readonly List<Enemigo> listaEnemigos = new List<Enemigo>();
    static string? batallaDescripcion;

    [HttpPost("crear-personaje-fuerza")]
    public IActionResult CrearPersonajeFuerza(string nombre, int agilidad, int magia)
    {
        var personaje = new PersonajeDeFuerza(nombre, agilidad, magia);
        listaPersonajes.Add(personaje);
        return Ok($"{nombre} ha sido creado como Personaje de Fuerza.");
    }

    [HttpPost("crear-personaje-agilidad")]
    public IActionResult CrearPersonajeAgilidad(string nombre, int fuerza, int agilidad, int magia)
    {
        var personaje = new PersonajeDeAgilidad(nombre, fuerza, agilidad, magia);
        listaPersonajes.Add(personaje);
        return Ok($"{nombre} ha sido creado como Personaje de Agilidad.");
    }

    [HttpPost("crear-personaje-magia")]
    public IActionResult CrearPersonajeMagia(string nombre, int fuerza, int agilidad, int magia)
    {
        var personaje = new PersonajeDeMagia(nombre, fuerza, agilidad, magia);
        listaPersonajes.Add(personaje);
        return Ok($"{nombre} ha sido creado como Personaje de Magia.");
    }

    [HttpPost("crear-enemigo")]
    public IActionResult CrearEnemigo(int vida, int nivel)
    {
        var enemigo = new Enemigo { Vida = vida, Nivel = nivel };
        listaEnemigos.Add(enemigo);
        return Ok("Enemigo ha sido creado.");
    }

    [HttpPost("ejecutar-batalla")]
    public IActionResult EjecutarBatalla()
    {
        var personaje1 = new PersonajeDeFuerza("Personaje1", 50, 20); 
        var personaje2 = new PersonajeDeAgilidad("Personaje2", 80, 100, 30);

        listaPersonajes.Clear();
        listaPersonajes.Add(personaje1);
        listaPersonajes.Add(personaje2);

        batallaDescripcion = "¡Comienza la batalla!\n";
        Turno.Atacarse(listaPersonajes);
        foreach (var personaje in listaPersonajes)
        {
            batallaDescripcion += $"{personaje.Atacar()}\n"; 

        }
        batallaDescripcion += "¡La batalla ha terminado!";

        return Ok("Batalla ejecutada. Usa el GET para ver la descripción.");
    }

    [HttpGet("obtener-descripcion-batalla")]
    public IActionResult ObtenerDescripcionBatalla()
    {
        if (string.IsNullOrEmpty(batallaDescripcion))
        {
            return NotFound("No se ha ejecutado ninguna batalla aún.");
        }

        return Ok(batallaDescripcion);
    }
}

