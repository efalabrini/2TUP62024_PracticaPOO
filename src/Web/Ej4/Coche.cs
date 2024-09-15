namespace Web.Ej4
{
    public class Coche : IVehiculo
    {
        int CombustibleInicial { get; set; }
        public Coche(int combustibleInicial) {
            CombustibleInicial = combustibleInicial;   
        }

        public string Conducir()
        {
            return CombustibleInicial > 0 ? "El coche está siendo manejado." : "El coche no tiene combustible.";
        }

        public bool CargarCombustible(int combustibleCarga)
        {
            CombustibleInicial += combustibleCarga;
            return true;
        }
    }
}
