using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Ej5;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5Controller : ControllerBase

    {
        private static List<Personaje> personajes = new List<Personaje>();
        private static List<Enemigo> enemigos = new List<Enemigo>();

        [HttpPost("crearPersonajeDeFuerza")]
        public IActionResult CrearPersonajeDeFuerza([FromBody] PersonajeDeFuerza personaje)
        {
            personajes.Add(personaje);
            return Ok($"Personaje de fuerza {personaje.Nombre} creado.");
        }

        [HttpPost("crearPersonajeDeAgilidad")]
        public IActionResult CrearPersonajeDeAgilidad([FromBody] PersonajeDeAgilidad personaje)
        {
            personajes.Add(personaje);
            return Ok($"Personaje de agilidad {personaje.Nombre} creado.");
        }

        [HttpPost("crearPersonajeDeMagia")]
        public IActionResult CrearPersonajeDeMagia([FromBody] PersonajeDeMagia personaje)
        {
            personajes.Add(personaje);
            return Ok($"Personaje de magia {personaje.Nombre} creado.");
        }

        [HttpPost("crearEnemigo")]
        public IActionResult CrearEnemigo([FromBody] Enemigo enemigo)
        {
            enemigos.Add(enemigo);
            return Ok($"Enemigo de nivel {enemigo.Nivel} creado.");
        }

        [HttpGet("batalla")]
        public IActionResult EjecutarBatalla()
        {
            var resultadoBatalla = new List<string>();

            foreach (var personaje in personajes)
            {
                resultadoBatalla.Add(personaje.Atacar());
            }

            var descripcionBatalla = string.Join("\n", resultadoBatalla);
            return Ok(descripcionBatalla);
        }
    }
        
            
        
}
