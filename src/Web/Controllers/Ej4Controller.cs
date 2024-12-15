using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Net;
using Web.Ej4;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4Controller : ControllerBase
    {
        [HttpPost("LoadFuelAndCreateNewCar")]
        public IActionResult CreateCar(int fuelQuantity)
        {
            if (fuelQuantity >= 0)
            {
                var newCar = new Coche(fuelQuantity);
                newCar.Conducir();
                return Ok(newCar.StateMessage);
            }
            else 
            {
                return BadRequest();
            }
        }

        [HttpPost("LoadFuelAndCreateNewEmptyTankCar")]
        public IActionResult CreateEmptyTankCar(int fuelQuantity)
        {
            if (fuelQuantity >= 0)
            {
                var newCar = new Coche(0);
                newCar.CargarCombustible(fuelQuantity);
                newCar.Conducir();
                return Ok(newCar.StateMessage);
            }
            else
            {
                return BadRequest();
            }
        }

    }
}
