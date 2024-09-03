using System.Security.Cryptography.X509Certificates;

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
}
