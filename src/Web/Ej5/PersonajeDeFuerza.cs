namespace Web.Ej5
{
    public class PersonajeDeFuerza : Personaje
    {
        public PersonajeDeFuerza(string nombre, int agilidad, int magia)
        {
            Name = nombre;
            Force = 100;
            Agility = agilidad;
            Magic = magia;
        }

        public override int CalcularDanio()
        {
            return Force  + Agility / 2 + Magic / 3;
        }

        public override string Atacar()
        {
            return $"{Name} hizo {CalcularDanio()} de daño de fuerza.";
        }
    }
}
