namespace Web.Ej5
{
    public class PersonajeDeAgilidad : Personaje
    {
        public PersonajeDeAgilidad(string nombre, int fuerza, int agilidad, int magia)
        {
            Name = nombre;
            Force = fuerza;
            Agility = agilidad * 2;
            Magic = magia;
        }

        public override int CalcularDanio()
        {
            return Force / 2 * Agility * Magic / 2;
        }
        public override string Atacar()
        {
            return $"{Name} hizo {CalcularDanio()} de daño agil.";
        }
    }
}
