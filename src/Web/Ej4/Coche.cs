namespace Web.Ej4
{
    public class Coche: IVehiculo
    {
        private int _combustible;

        public Coche(int combustibleInicial)
        {
            _combustible = combustibleInicial;
        }

        public void Conducir()
        {
            if (_combustible > 0)
            {
                Console.WriteLine("El coche está siendo manejado");
            }
            else
            {
                Console.WriteLine("El coche no tiene combustible");
            }
        }

        public bool CargarCombustible(int cantidad)
        {
            _combustible += cantidad;
            return true;
        }
    }
}
