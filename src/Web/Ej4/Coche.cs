namespace Web.Ej4
{
    public class Coche : IVehiculo
    {
        static private int _Combustible { get; set; }
        public Coche(int combustible)
        {
            _Combustible = combustible;
        } 

        public bool CargarCombustible(int cantidad)
        {
            _Combustible += cantidad;
            return true;
        }

        public string Conducir()
        {
            if (_Combustible > 0)
            {
                return ("El coche esta siendo manejado");
            }

            return ("El coche no tiene combustible");
        }
    }
}
