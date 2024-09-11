using System.Net.Http.Headers;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;
using Microsoft.AspNetCore.Mvc;

using Web.ej5;


namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej5Controllers : ControllerBase
{

    static List<Personaje> listaPersonaje = new List<Personaje>();
    static List<Enemigo> listaEnemigo = new List<Enemigo>();


    [HttpPost("[Action]")]

    public string CreacionPersonajeDeFuerza(string nombre, double agilidad, double magia, double? fuerza = null){
        
        

        PersonajeDeFuerza personajeFuerza = fuerza.HasValue ? new PersonajeDeFuerza(nombre, agilidad, magia, fuerza.Value) : new PersonajeDeFuerza(nombre, agilidad, magia);

        listaPersonaje.Add(personajeFuerza);

        return "Personaje de Fuerza creado";
    }

    [HttpPost("[Action]")]

    public string CreacionPersonajeDeAgilidad(string nombre, double agilidad, double magia, double fuerza ){
        
        

        PersonajeDeAgilidad personajeAgilidad = new PersonajeDeAgilidad(nombre, agilidad, magia, fuerza);

        listaPersonaje.Add(personajeAgilidad);

        return "Personaje de Agilidad creado";
    }

    [HttpPost("[Action]")]

    public string CreacionPersonajeDeMagia(string nombre, double agilidad, double fuerza, double? magia = null){
        
        

        PersonajeDeMagia personajeMagia = magia.HasValue ? new PersonajeDeMagia(nombre, agilidad, fuerza, magia.Value) : new PersonajeDeMagia(fuerza, nombre, agilidad);

        listaPersonaje.Add(personajeMagia);

        return "Personaje de Magia creado";
    }

     [HttpPost("[Action]")]

    public string CreacionEnemigo(int vida, int nivel ){
        

        Enemigo personajeEnemigo = new Enemigo(vida, nivel);

        listaEnemigo.Add(personajeEnemigo);

        return "Enemigo creado";
    }

    [HttpGet("[Action]")]

    public IActionResult Batalla(){

        
        Turno.Atacarse(listaPersonaje, listaEnemigo);
        Turno.MoverFichas(listaPersonaje[0],6, 15);
        Turno.MoverFichas(listaEnemigo[0],10, 23);
        return Ok("La batalla comenzo, mire la terminal para ver los resultados");
    }
}