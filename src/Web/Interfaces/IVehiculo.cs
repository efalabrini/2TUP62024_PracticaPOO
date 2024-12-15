namespace Web.Interfaces
{
    public interface IVehiculo
    {
        public void Conducir()
        {

        }

        public bool CargarCombustible(int cantCombustible)
        {
             if (cantCombustible >= 0)
                return true;
             else return false;
          
        }
    }
}
