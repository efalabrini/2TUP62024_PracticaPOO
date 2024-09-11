/*﻿using Microsoft.AspNetCore.Http;
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
} */

 using System;
using Microsoft.AspNetCore.Mvc;
using Web.Ej4;

namespace Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class Ej4Controller : ControllerBase
{
    [HttpPost("CrearAuto")]
    public IActionResult CrearAuto([FromBody] int CantidadCombustible)
    {

        var coche = new Coche(CantidadCombustible);

        coche.Conducir();
        return Ok(coche.Mensaje);
    }

    [HttpPost("CrearAutoSinComb")]
    public IActionResult CrearAutoSinComb([FromBody] int CantCombustible)
    {
            var coche = new Coche(0);

            coche.CargarCombustible(CantCombustible);
            coche.Conducir();
            return Ok(coche.Mensaje);
       
    }


} 
