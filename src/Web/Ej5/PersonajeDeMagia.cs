using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Web.Ej5
{
    public class PersonajeDeMagia : Personaje
    {
        public PersonajeDeMagia(string nombre, int fuerza, int agilidad, int magia)
        {
            Name = nombre;
            Force = fuerza;
            Agility = agilidad;
            Magic = magia * 2;
        }
        public PersonajeDeMagia(string nombre, int fuerza, int agilidad)
        {
            Name = nombre;
            Force = fuerza;
            Agility = agilidad;
            Magic = 60;
        }
        public override int CalcularDanio()
        {
            return Force + Agility + Magic * 4;
        }

        public override string Atacar()
        {
            return $"{Name} hizo {CalcularDanio()} de daño magico";
        }
    }
}
