using Web.Ej4.Interfaces;

namespace Web.Ej4.Entities
{
    public class Coche : IVehiculo
    {
        public int Combustible {  get; set; }
        public Coche(int cantidadCombusible) 
        {
            Combustible = cantidadCombusible;
        }

        public string Conducir()
        {
            if (Combustible > 0)
            {
                string unidad = Combustible == 1 ? "litro" : "litros";
                return $"Estoy conduciendo con {Combustible} {unidad} de combustible";
            }
            return "El coche no tiene combustible";
        }

        public bool CargarCombustible(int cantidadCombustible) 
        {
            Combustible += cantidadCombustible;
            return true;
        }
    }
}
