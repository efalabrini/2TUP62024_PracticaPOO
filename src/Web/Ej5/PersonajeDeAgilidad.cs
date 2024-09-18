using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Web.Ej5
{
    public class PersonajeDeAgilidad : Personaje, IMoverse
    {
        public PersonajeDeAgilidad(string nombre, int agilidad, int magia, int fuerza)
        {
            Nombre = nombre;
            Agilidad = agilidad;
            Magia = magia;
            Fuerza = fuerza;
        }

        public override int CalcularDanio()
        {
            return (Fuerza / 2) * Agilidad * (Magia / 2);
        }
    }
}
