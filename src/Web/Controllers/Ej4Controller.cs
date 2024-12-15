

using Microsoft.AspNetCore.Mvc;

using Web.ej4;

[ApiController]
[Route("[controller]")]


public class Ej4Controller : ControllerBase
{
    [HttpPost("[action]")]
    public IActionResult AddCar(int initialFuel)
    {
        Car car1 = new Car(initialFuel);
        return Ok(car1.Drive());

    }

    [HttpPost("[action]")]
    public IActionResult AddCarWithoutFuel(int amountLoad)
    {
        Car car1 = new Car(0);
        car1.LoadFuel(amountLoad);
        return Ok(car1.Drive());

    }
}