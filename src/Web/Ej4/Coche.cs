namespace Web.Ej4
{
    public class Coche : IVehiculo
    {

        public int fuel { get; set; }
        public Coche(int startingFuel)
        {
            fuel = startingFuel;
        }

        public Coche()
        {
        }

        public string Conducir()
        {
            if (fuel > 0)
            {
                return "El coche esta siendo manejado.";
            }

            return "El coche no tiene combustible.";

        }

        public bool CargarCombustible(int Fuel)
        {

            fuel += Fuel;

            return true;
        }

        public bool CargaCombustible(int fuel)
        {
            throw new NotImplementedException();
        }
    }
}
