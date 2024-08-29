using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
using Web.Ej5;

[ApiController]
[Route("[controller]")]
public class Ej5Controller : ControllerBase
{

    static List<Personaje> listaPersonajes = new List<Personaje>();
    static List<Enemigo> listaEnemigos = new List<Enemigo>();

    [HttpPost("[action]")]
    public IActionResult CrearPersonajeDeFuerza([FromForm] string nombre, [FromForm] int agilidad, [FromForm] int magia)
    {
        PersonajeDeFuerza personaje = new PersonajeDeFuerza(nombre, agilidad, magia);
        listaPersonajes.Add(personaje);
        return Ok("Personaje de fuerza creado");
    }

    [HttpPost("[action]")]
    public IActionResult CrearPersonajeDeAgilidad([FromForm] string nombre, [FromForm] int fuerza, [FromForm] int agilidad, [FromForm] int magia)
    {
        PersonajeDeAgilidad personaje = new PersonajeDeAgilidad(nombre, fuerza, agilidad, magia);
        listaPersonajes.Add(personaje);
        return Ok("Personaje de agilidad creado");
    }

    [HttpPost("[action]")]
    public IActionResult CrearPersonajeDeMagia([FromForm] string nombre, [FromForm] int agilidad, [FromForm] int magia)
    {
        PersonajeDeMagia personaje = new PersonajeDeMagia(nombre, agilidad, magia);
        listaPersonajes.Add(personaje);
        return Ok("Personaje de magia creado");
    }

    [HttpPost("[action]")]
    public IActionResult CrearEnemigo([FromForm] int vida, [FromForm] int nivel)
    {
        Enemigo personaje = new Enemigo{
            Vida = vida,
            Nivel = nivel
        };
        listaEnemigos.Add(personaje);
        return Ok("Enemigo creado");
    }

    [HttpGet("[action]")]
    public IActionResult CrearBatalla()
    {
        Turno.Atacarse(listaPersonajes);
        Turno.MoverFichas(listaEnemigos[0], 10, 5, "derecha", "arriba");
        Turno.MoverFichas(listaPersonajes[2], 8, 12, "izquierda", "abajo");
        Turno.Atacarse(listaPersonajes);
        
        return Ok("Batalla finalizada. Murieron todos. Mire en la consola para ver el despelote que se armó.");
    }
}
