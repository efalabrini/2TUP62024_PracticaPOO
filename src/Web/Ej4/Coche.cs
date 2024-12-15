namespace Web.Ej4;

public class Coche : IVehiculo
{
    public int combustible;
    public Coche(int cantCombustible)
    {
        combustible = cantCombustible;
    }

    public bool CargarCombustible(int cantCombustible)
    {
       this.combustible+=cantCombustible;
       return true;
    }

    public string Conducir()
    {
        if (this.combustible > 0)
        {
            return ("El coche está siendo manejado.");
        } else 
        {
            return ("El coche no tiene combustible.");
        }
    }
}