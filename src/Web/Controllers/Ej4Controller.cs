using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Ej4;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4Controller : ControllerBase
    {
        [HttpPost("Drive")]
        public ActionResult Drive(int fuel)
        {
            var car = new Coche(fuel);

            return Ok(car.Conducir());
        }

        [HttpPost("FuelCar")]
        public ActionResult FuelCar(int fuel)
        {
            var car = new Coche();
            car.CargarCombustible(fuel);

            return Ok(car.Conducir());
        }
    }
}
