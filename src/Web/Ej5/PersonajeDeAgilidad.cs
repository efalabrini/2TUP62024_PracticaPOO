namespace Web.Ej5
{
    public class PersonajeDeAgilidad : Personaje
    {
        public PersonajeDeAgilidad(string nombre, float magia, float fuerza, float agilidad) : base(nombre,magia,fuerza,agilidad) { }

        public override float CalcularDanio()
        {
            return Fuerza / 2 * Agilidad * Magia / 2;
        }
    }
}
