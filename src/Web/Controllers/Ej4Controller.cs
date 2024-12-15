using Microsoft.AspNetCore.Mvc;
using Web.Ej4;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class Ej4Controller : ControllerBase
{
    [HttpPost("Drive")]
    public ActionResult Drive(int fuel)
    {
        var car = new Coche(fuel);
        return Ok(car.Conducir());
    }

    [HttpPost("FillFuel")]
    public ActionResult FillFuel(int fuel)
    {
        var car = new Coche();
        car.CargarCombustible(fuel);
        return Ok(car.Conducir());
    }
}