using Web.Interfaces;

namespace Web.Ej4
{
    public class Coche : IVehiculo
    {
        public int cantCombustible { get; set; }

        public Coche(int cantCombustible)
        {
            cantCombustible = cantCombustible;
        }

        public string Conducir()
        {
            if(cantCombustible > 0)
            {
                return "El coche esta siendo manejado";
            }
            else
            {
                return "El coche no tiene combustible";
            }
        }

        public bool CargarCombustible(int cantCombustible)
        {
            cantCombustible += 1;
            return true;
        }
    }
}
