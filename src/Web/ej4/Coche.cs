namespace Web.ej4
{
    public class Car : IVehicle
    {
        public int fuel { get; set; }
        public Car(int initialFuel)
        {
            fuel = initialFuel;
        }

        public string Drive()
        {
            if (fuel > 0)
            {

                return "El coche esta siendo manejado";
            }
            else
            {
                return "El coche no tiene combustible";
            }
        }

        public bool LoadFuel(int amountLoad)
        {
            fuel = fuel + amountLoad;
            return true;
        }
    }
}