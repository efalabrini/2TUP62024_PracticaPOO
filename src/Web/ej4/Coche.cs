namespace Web.ej4
{
    public class Coche : IVehiculo
    {

        public int cantCombustible { get; set; }

        public Coche(int cantCombustibleIngresada)
        {
            cantCombustible = cantCombustibleIngresada;
        }

        public string Conducir()
        {   
            if (cantCombustible > 0)
            {
                return "El coche esta siendo manejado";
            }

            return "El coche esta sin nafta";
            
        }

        public bool CargarCombustible(int cantCombustibleCargar)
        {
            cantCombustible = cantCombustibleCargar;

            return true;

        }
    }
}