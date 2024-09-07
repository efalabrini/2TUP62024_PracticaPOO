using Microsoft.AspNetCore.Mvc;
using Web.Ej4;

namespace Web.Controllers;

[ApiController]
[Route("[controller]/[Action]")]

public class Ej4Controller: ControllerBase
{
    [HttpGet]
    public IActionResult NewCar(int fuel){
        Car car = new Car(fuel);
        return Ok(car.Drive());
    }

    [HttpGet]
    public IActionResult NewCarNoFuel(int fuel){
        Car car = new Car(0);
        car.LoadFuel(fuel);
        return Ok(car.Drive());
    }
}