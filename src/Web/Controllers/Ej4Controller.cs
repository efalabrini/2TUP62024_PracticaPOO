
using Web.Ej4;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
[ApiController]
[Route("[controller]")]
public class Ej4Controller : ControllerBase
{
    [HttpPost("Drive")]
    public IActionResult Drive(int fuel)
    {
        var car = new Coche(fuel);
        return Ok(car.Drive());
    }
    
    [HttpPost("Carry")]
    public IActionResult Carry(int fuel)
    {
        var car = new Coche();
        car.LoadFuel(fuel);
        return Ok(car.Drive());
    }
}
