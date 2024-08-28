using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Ej5;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5Controller : ControllerBase
    {
        static List<Personaje> listaPersonajes = new List<Personaje>();
        static List<Enemigo> listaEnemigos = new List<Enemigo>();

        [HttpPost("[action]")]
        public ActionResult AddPersonajeFuerza(string nombre, int agilidad, int magia)
        {
            var personaje = new PersonajeDeFuerza(nombre, agilidad, magia);
            listaPersonajes.Add(personaje);
            return Ok($"{nombre} ha sido creado como personaje de fuerza");
        }

        [HttpPost("[action]")]
        public ActionResult AddPersonajeAgilidad(string nombre,int fuerza, int agilidad, int magia)
        {
            var personaje = new PersonajeDeAgilidad(nombre, fuerza, agilidad, magia);
            listaPersonajes.Add(personaje);
            return Ok($"{nombre} ha sido creado como personaje de agilidad");
        }

        [HttpPost("[action]")]
        public ActionResult AddPersonajeMagia(string nombre, int fuerza, int agilidad)
        {
            var personaje = new PersonajeDeMagia(nombre, fuerza, agilidad);
            listaPersonajes.Add(personaje);
            return Ok($"{nombre} ha sido creado como personaje de magia");
        }

        [HttpPost("[action]")]
        public ActionResult AddEnemigo(int vida, int nivel)
        {
            var enemigo = new Enemigo(vida, nivel);
            listaEnemigos.Add(enemigo);
            return Ok($"El enemigo de nivel {nivel} se ha creado");
        }

        [HttpGet]
        public ActionResult Batalla()
        {
            Turno.Atacarse(listaPersonajes);
            return Ok("la batalla ha terminado, los personajes han atacado");
        }



    }
}
