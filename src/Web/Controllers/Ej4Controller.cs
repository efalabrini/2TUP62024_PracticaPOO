using Microsoft.AspNetCore.Mvc;
using Web.Ej4.Entities;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej4Controller : Controller
    {
        [HttpGet("[action]")]
        public ActionResult GetMensaje([FromQuery]int combustible)
        {
            
            var auto = new Coche(combustible);
            string mensaje = auto.Conducir();
            return Ok(mensaje);
        }
        [HttpGet("[action]")]
        public ActionResult GetCocheSinCombustible([FromQuery] int combustible)
        {

            var auto = new Coche(0);
            auto.CargarCombustible(combustible);
            string mensaje = auto.Conducir();
            return Ok(mensaje);
        }
    }
}

/*
 Ej4

Crear un endpoint que reciba un valor entero de cantidad de combustible, cree un coche con dicha cantidad de combustible, y retorne el mensaje que corresponde a conducir el coche.

Crear otro endpoint que reciba un valor entero de cantidad de combustible, cree un conche sin combustible, le cargue la cantidad indicada en el parámetro, y retorne el mensaje que corresponde a conducir el coche.

 */
