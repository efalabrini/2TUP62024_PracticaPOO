

using Web.Interfaces;

namespace Web.Classes
{
    public class Car : IVehicle
    {
        private float fuel { get; set; }
        
        public Car(float fuel)
        {
            this.fuel = fuel;
        }

        public string drive()
        {
            if (fuel > 0)
            {
                return ("El auto esta siendo manejado");
            }
            else
            {
                return ("El auto no tiene nafta");
            }
        }


        public bool refuel(float fuelAmount)
        {
            if (fuelAmount > 0)
            {
                this.fuel = this.fuel + fuelAmount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public float Getfuel()
        {
            return this.fuel;
        }
    }
}
