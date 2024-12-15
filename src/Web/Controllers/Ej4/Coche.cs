
namespace Web.Ej4;
public class Coche : IVehiculo 
{
    public int Fuel {get; set;}
    public Coche(int startingFuel)
    {
        Fuel = startingFuel;
    }

    public Coche()
    {
    }

    public string Conducir()
    {
        if(Fuel > 0)
        {
            return "El coche está siendo manejado";
        }
        
        return "El coche no tiene comustible";
        
    }

    public bool CargarCombustible(int fuel)
    {
        Fuel += fuel;
        return true;
    }
}