using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web.Classes;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej4Controller : Controller
    {
        [HttpPost("[action]")]
        public IActionResult CarCreate1([FromQuery] float fuel)
        {
            Car car = new Car(fuel);
            return Ok($"{car.drive()} y tiene {car.Getfuel()} litros de nafta");
        }

        [HttpPost("[action]")]
        public IActionResult CreateCar2([FromQuery] float fuel)
        {
            Car car = new Car(0);
            car.refuel(fuel);
            return Ok($"{car.drive()} y tiene {car.Getfuel()} litros de nafta");
        }
    }
}
