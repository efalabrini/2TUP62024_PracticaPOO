/*﻿using System.Security.Cryptography.X509Certificates;

namespace Web.Ej4
{
    public class Coche : IVehiculo
    {
        public int FuelTank { get; set; }
        public string StateMessage { get; set; } = " ";
        public Coche(int inicialFuelTank)
        {
            FuelTank = inicialFuelTank;
        }
        public void Conducir()
        {
            if (FuelTank != 0)
            { StateMessage = "El coche está siendo manejado"; }
            else
            {
                StateMessage = "El coche no tiene combustible";
            }

        }

        public bool CargarCombustible(int quantity) 
        {
            FuelTank += quantity;
            return true;
        }
    }
}*/


using System;

namespace Web.Ej4;

public class Coche: IVehículo
{
    public int Combustible { get; set;}
    public string Mensaje {get;set;}

    public Coche(int TanqueInicial)
    {
      Combustible = TanqueInicial;
    }

    public void Conducir()
    {
        if(Combustible > 0)
        {
            {Mensaje = "El coche esta siendo manejado";}
        }else 
        {
            { Mensaje = "El coche no tiene combustible";}
        }
    }

    public bool CargarCombustible(int Cantidad)
    {
        if(Cantidad > 0)
        {
            Combustible += Cantidad;
            return true;
        }else{
            return false;
        }
    }
}
 