/*namespace Web.Ej4
{
    public interface IVehiculo
    {
        public void Conducir();
        public bool CargarCombustible(int fuelQuantity);

    }
}*/

 using System;

namespace Web.Ej4;

public interface IVehículo
{
    public void Conducir();
    public bool CargarCombustible(int CantCombustile);
}
 