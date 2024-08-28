namespace Web.Ej4
{
    public class Coche : IVehiculo
    {
        public int Combustible {  get; set; }
        public Coche(int cantCombustible) 
        {
            Combustible = cantCombustible;
        }

        public string Conducir()
        {
            if (Combustible > 0)
            {
                return "el coche esta siendo manejado";
            }
            else
            {
                return "El coche no tiene combustible";
            }

        }

        public bool CargarCombustible(int cantCombustible)
        {
            Combustible += cantCombustible;
            return true;
        }
    }
}
