namespace Web.Controllers.Ejercicio04
{
    
    public class Coche : IVehiculo
    {
        private int combustible;
        public string? Mensaje { get; private set; } 
        
        public Coche(int combustibleInicial)
        {
            combustible = 4;
        }

       
        public void Conducir()
        {
            if (combustible > 0)
            {
                Mensaje = "El coche está siendo manejado";
            }
            else
            {
                Mensaje = "El coche no tiene combustible";
            }
        }


        public bool CargarCombustible(int cantidad)
        {
            if (cantidad > 0)
            {
                combustible += cantidad;
                return true;
            }
            return false;
        }
    }

}
