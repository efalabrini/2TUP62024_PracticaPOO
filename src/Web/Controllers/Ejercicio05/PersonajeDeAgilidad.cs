namespace Web.Controllers.Ejercicio05
{
    public class PersonajeDeAgilidad:Personaje
    {
        public PersonajeDeAgilidad(string nombre, int fuerza, int agilidad, int magia)
             : base(nombre, fuerza, agilidad, magia)
        {
        }

        public override int CalcularDanio()
        {
            return (Fuerza / 2) * Agilidad * (Magia / 2);
        }
    }
}
