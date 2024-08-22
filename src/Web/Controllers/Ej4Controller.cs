
using Microsoft.AspNetCore.Mvc;
using Web.Ej4;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        [HttpPost("crear-y-conducir")]
        public IActionResult CrearYConducir([FromBody] int cantidadCombustible)
        {
            Car car = new Car(cantidadCombustible);
            car.Conducir();
            return Ok(car.ObtenerMensaje());
        }

        [HttpPost("crear-cargar-y-conducir")]
        public IActionResult CrearCargarYConducir([FromBody] int cantidadCombustible)
        {
            Car car = new Car(0);
            car.CargarCombustible(cantidadCombustible);
            car.Conducir();
            return Ok(car.ObtenerMensaje());
        }
    }
}
