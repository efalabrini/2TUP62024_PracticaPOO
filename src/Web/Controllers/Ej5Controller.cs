using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Ej5;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej5Controller : ControllerBase
    {
        static List<Personaje> listaPersonajes = new List<Personaje>();
        static List<Enemigo> listaEnemigos = new List<Enemigo>();

        [HttpPost("crear-personaje-fuerza")]
        public ActionResult CrearPersonajeFuerza(string nombre, int agilidad, int magia)
        {
            var personaje = new PersonajeDeFuerza(nombre, agilidad, magia);
            listaPersonajes.Add(personaje);
            return Ok($"Personaje de fuerza creado: {personaje.Nombre}");
        }

        [HttpPost("crear-personaje-agilidad")]
        public ActionResult CrearPersonajeAgilidad(string nombre, int fuerza, int agilidad, int magia)
        {
            var personaje = new PersonajeDeAgilidad(nombre, fuerza, agilidad, magia);
            listaPersonajes.Add(personaje);
            return Ok($"Personaje de agilidad creado: {personaje.Nombre}");
        }

        [HttpPost("crear-personaje-magia")]
        public ActionResult CrearPersonajeMagia(string nombre, int fuerza, int agilidad, int magia)
        {
            var personaje = new PersonajeDeMagia(nombre, fuerza, agilidad, magia);
            listaPersonajes.Add(personaje);
            return Ok($"Personaje de magia creado: {personaje.Nombre}");
        }

        [HttpPost("crear-enemigo")]
        public ActionResult CrearEnemigo(int vida, int nivel)
        {
            var enemigo = new Enemigo(vida, nivel);
            listaEnemigos.Add(enemigo);
            return Ok($"Enemigo creado con nivel: {enemigo.Nivel}");
        }

        [HttpGet("ejecutar-pelea")]
        public ActionResult EjecutarPelea()
        {
            var descripcion = new List<string>();
            descripcion.Add("Inicio del juego...");

            foreach (var personaje in listaPersonajes)
            {
                descripcion.Add(personaje.Atacar());
                Turno.MoverFichas(personaje);
                descripcion.Add($"{personaje.Nombre} se ha movido.");
            }

            foreach (var enemigo in listaEnemigos)
            {
                Turno.MoverFichas(enemigo);
                descripcion.Add($"Un enemigo de nivel {enemigo.Nivel} se ha movido.");
            }

            descripcion.Add("Pelea finalizada!");

            return Ok(string.Join("\n", descripcion));
        }
    }
}
