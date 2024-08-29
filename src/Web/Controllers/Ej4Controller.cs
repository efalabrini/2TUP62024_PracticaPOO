using System.Net.Http.Headers;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;
using Microsoft.AspNetCore.Mvc;

using Web.ej4;


namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej4Controllers : ControllerBase
{

    [HttpPost("[Action]")]

    public string CargaNafta(int CargarCombustible){

        Coche auto = new Coche(CargarCombustible);

        return auto.Conducir();

    }

    [HttpPost("[Action]")]

    public string CargarCombustible(int cargar){

        Coche auto = new Coche(0);

        auto.CargarCombustible(cargar);

        return auto.Conducir();
    }
}
