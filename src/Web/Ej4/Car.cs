using Web.Ej4;
namespace Web.Ej4
{
    public class Car : IVehiculo
    {
        private int combustible;
        private string mensaje;

        public Car(int combustibleInicial)
        {
            combustible = combustibleInicial;
            mensaje = "El auto está parado";
        }

        public void Conducir()
        {
            if (combustible > 0)
            {
                mensaje = "El auto está siendo manejado";
            }
            else
            {
                mensaje = "El auto no tiene combustible";
            }
        }

        public bool CargarCombustible(int cantidad)
        {
            combustible += cantidad;
            return true;
        }

        public string ObtenerMensaje()
        {
            return mensaje;
        }
    }
}
