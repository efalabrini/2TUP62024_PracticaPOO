namespace Web.Controllers.Ejercicio05
{
    public class PersonajeDeFuerza:Personaje
    {
        public PersonajeDeFuerza(string nombre, int agilidad, int magia)
            : base(nombre, 100, agilidad, magia)
        {
        }

        public override int CalcularDanio()
        {
            return Fuerza + Agilidad + Magia; // Ejemplo de fórmula
        }
    }
}
