using Microsoft.AspNetCore.Mvc;
using System.Reflection.PortableExecutable;
using Web.Ej5;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej5Controller : ControllerBase
    {
        static List<Personaje> listaPersonajes = new List<Personaje>();
        static List<Enemigo> listaEnemigos = new List<Enemigo>();

        [HttpPost("[action]")]
        public IActionResult PersonajeDeFuerza(string nombre, float agilidad, float magia)
        {
            PersonajeDeFuerza personaje1 = new PersonajeDeFuerza(nombre, agilidad, magia);
            listaPersonajes.Add(personaje1);
            return Ok(personaje1);

        }

        [HttpPost("[action]")]
        public IActionResult PersonajeDeAgilidad(string nombre, float agilidad, float magia, float fuerza)
        {
            PersonajeDeAgilidad personaje1 = new PersonajeDeAgilidad(nombre, agilidad, magia, fuerza);
            listaPersonajes.Add(personaje1);
            return Ok(personaje1);
        }

        [HttpPost("[action]")]
        public IActionResult PersonajeDeMagia(string nombre, float agilidad, float fuerza, float? magia = null)
        {
            PersonajeDeMagia personaje1 = magia.HasValue ? new PersonajeDeMagia(nombre, agilidad, fuerza, magia.Value) : new PersonajeDeMagia(nombre, fuerza, agilidad);
            listaPersonajes.Add(personaje1);
            return Ok(personaje1);
        }

        [HttpPost("[action]")]
        public IActionResult Enemigo(float vida, int nivel)
        {
            Enemigo enemigo1 = new Enemigo(vida, nivel);
            listaEnemigos.Add(enemigo1);
            return Ok(enemigo1);
        }

        [HttpGet("[action]")]
        public IActionResult ListaDePersonajes()
        {
            return Ok(listaPersonajes);
        }

        [HttpGet("[action]")]
        public IActionResult ListaDeEnemigos()
        {
            return Ok(listaEnemigos);
        }

        [HttpPost("[action]")]
        public IActionResult InicioBatalla()
        {
            if (listaPersonajes.Count == 0 || listaEnemigos.Count == 0)
            {
                return BadRequest("No hayt suficientes personajes o sufiencies enemigos para arrancar la batalla");
            }
            else 
            {
                float dañoAcumulado = listaPersonajes.Sum((personajes) => personajes.CalcularDanio());
                float vidaAcumulada = listaEnemigos.Sum((enemigos) => enemigos.Vida);
                if(dañoAcumulado >= vidaAcumulada)
                {
                    return Ok($"Ganaron los personajes realizando {dañoAcumulado} de daño");
                }
                else
                {
                    return Ok($"Los enemigos ganaron...");
                }



            }
        }

    }

}
