namespace Web.Ej5
{
    public class PersonajeDeFuerza : Personaje
    {
        public PersonajeDeFuerza(string nombre, float agilidad, float magia, int fuerza = 100) : base(nombre, fuerza, magia, agilidad) { }

        public override float CalcularDanio()
        {
            return Fuerza * Magia - Agilidad;
        }


    }
}
