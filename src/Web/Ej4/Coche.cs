using System;

namespace Web.Ej4;

public class Coche : IVehiculo
{
    public int Fuel { get; set; }
    public Coche(int startingFuel)
    {
        Fuel = startingFuel;
    }
    public Coche()
    {}
    public string Drive()
    {
        if (Fuel > 0)
        {
            return "El coche está siendo manejado";
        }
        return  "El coche no tiene combustible";
    }
    public bool LoadFuel(int fuel)
    {
        Fuel+=fuel;
        return true;
    }
}
