namespace Web.Ej4
{
    public class Car : IVehicle{
        
        public int fuel {get;set;}
        public Car(int liters){
            fuel=liters;
        }
        public string Drive(){
            if (fuel > 0)
            {
                return "El coche está siendo manejado";
            }
            else{
                return  "El coche no tiene combustible";
            }
        }
        public bool LoadFuel(int liters){
            fuel += liters;
            return true;
        }
    }
}