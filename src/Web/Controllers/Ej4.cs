using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Ej4;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4 : ControllerBase
    {
        [HttpPost("nuevo-coche")]
        public ActionResult NuevoCoche(int cantCombustible){
            /*Coche coche=new Coche(cantCombustible);
            return Ok(coche.Conducir());*/
            return Ok(new Coche(cantCombustible).Conducir()); 
            
        }

         [HttpPost("nuevo-coche-vacio")]
        public ActionResult NuevoCocheVacio(int cantCombustible){
            Coche coche=new Coche(0);
            coche.CargarCombustible(cantCombustible);
            return Ok(coche.Conducir());
        }


    }
}
