using Microsoft.AspNetCore.Mvc;
using Web.Domain.Entities;
using Web.Dtos;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej5Controller : Controller
    {
        static List<Personaje> listaPersonajes = new List<Personaje>();
        static List<Enemigo> listaEnemigos = new List<Enemigo>();

        [HttpPost("[action]")]
        public ActionResult<PersonajeDeFuerza> CreateForceCharacter([FromBody]PersonajeDeFuerza crearPersonaje)
        {
            listaPersonajes.Add(crearPersonaje);
            return NoContent();
        }

        [HttpPost("[action]")]
        public ActionResult<PersonajeDeMagia> CreateMagicCharacter([FromBody] PersonajeDeMagia crearPersonaje)
        {
            listaPersonajes.Add(crearPersonaje);
            return NoContent();
        }

        [HttpPost("[action]")]
        public ActionResult<PersonajeDeAgilidad> CreateAgilityCharacter([FromBody] PersonajeDeAgilidad crearPersonaje)
        {
            listaPersonajes.Add(crearPersonaje);
            return NoContent();
        }

        [HttpPost("[action]")]
        public ActionResult<Enemigo> CreateEnemy([FromBody] EnemyDto enemigo) 
        {
            var enemy = new Enemigo(enemigo.Level);
            listaEnemigos.Add(enemy);
            return NoContent();
        }



        [HttpGet("[action]")]
        public IActionResult GetAllCharacters()
        {
            return Ok(listaPersonajes);
        }

        [HttpGet("[action]")]
        public IActionResult GetAllEnemys()
        {
            return Ok(listaEnemigos);
        }

        [HttpGet("[action]")]
        public ActionResult<string> Battle()
        {
            if (listaPersonajes.Count == 0 || listaEnemigos.Count == 0)
            {
                return BadRequest("No hay suficientes personajes o enemigos para jugar");
            }
            var battleSummary = new List<string>();
            int count = 0;
            while (listaEnemigos.Count > 0)
            {
                foreach (var character in listaPersonajes.ToList()) 
                {
                    if (listaEnemigos.Count == 0) break;

                    var damage = character.CalculateDamage();
                    var enemy = listaEnemigos[0];
                    battleSummary.Add($"{character.Atack(damage)}\n{enemy.ReciveDamage(damage)}");

                    if (enemy.HealtPoints <= 0)
                    {
                        listaEnemigos.RemoveAt(0);
                        if (listaEnemigos.Count > 0)
                        {
                            var nextEnemy = listaEnemigos[0].HealtPoints;
                            var text = $"\n\nA new enemy has comming...({nextEnemy} HP ) \n\n";
                            battleSummary.Add(text);
                        }
                    }
                }

                count++;
            }

            var battleResume = string.Join("\n", battleSummary);
            return Ok($"La batalla duró {count} turnos.\n\nResumen de la batalla:\n\n{battleResume}");
        }
    }
}

/*

Crear endpoints para:
- Crear un personaje de fuerza.
- Crear un personaje de agilidad.
- Crear un personaje de magia.
- Crear un un enemigo.
(Usar verbo POST)

- Crear un endpoint que ejecute una batalla y retorne una cadena de texto con la descripción de la misma.
(Usar verbo GET).
Utilizar la creatividad para crear un texto que representa la batalla en base a la ejecución de los métodos que se definieron en las clases.

Para almacenar los personajes y los enemigos, puede utilizar listas estáticas en el controller.
Ejemplo:

 */
