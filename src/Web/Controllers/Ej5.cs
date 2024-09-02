using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Ej5;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5 : ControllerBase
    {
        static List<Personaje> listaPersonajes = new List<Personaje>();
        static List<Enemigo> listaEnemigos = new List<Enemigo>();
        [HttpPost("PersonajeFuerza")]
        public ActionResult PersonajeFuerza(string _nombre, int _agilidad,int _magia){
            PersonajeDeFuerza personaje=new PersonajeDeFuerza( _nombre, _agilidad, _magia);
            listaPersonajes.Add(personaje);
            return Ok(personaje);
        }

        [HttpPost("PersonajeAgilidad")]
        public ActionResult PersonajeAgilidad(string _nombre, int _fuerza, int _agilidad,int _magia){
            PersonajeDeAgilidad personaje=new PersonajeDeAgilidad( _nombre,_fuerza, _agilidad, _magia);
            listaPersonajes.Add(personaje);
            return Ok(personaje);
        }

        [HttpPost("PersonajeMagia")]
        public ActionResult PersonajeMagia(string _nombre, int _fuerza, int _agilidad,int? _magia){
            PersonajeDeMagia personaje=_magia==null?new PersonajeDeMagia( _nombre,_fuerza, _agilidad):new PersonajeDeMagia( _nombre,_fuerza, _agilidad, _magia.GetValueOrDefault());
            listaPersonajes.Add(personaje);
            return Ok(personaje);
        }
        [HttpPost("CrearEnemigo")]
        public ActionResult CrearEnemigo(int _vida,int _nivel){
            Enemigo enemigo=new Enemigo(_vida,_nivel);
            listaEnemigos.Add(enemigo);
            return Ok(enemigo);
        }

        [HttpGet("Batalla")]
        public ActionResult Batalla(){
            return Ok(Turno.Atacarse(listaPersonajes));
        }
    }
}
