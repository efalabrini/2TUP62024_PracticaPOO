using static System.Runtime.InteropServices.JavaScript.JSType;
using Web.Interfaces;

namespace Web.Classes
{
    public abstract class Character : IMove
    {
        protected string Name { get; set; }
        protected float Strength { get; set; }
        protected float Agility { get; set; }
        protected float Magic { get; set; }

        public Character(string name, float strength, float agility, float magic)
        {
            Name = name;
            Strength = strength;
            Agility = agility;
            Magic = magic;
        }

        protected abstract float damageCalculate();


        public virtual string attack()
        {
            return $"El personaje {Name} atacó, haciendo {damageCalculate()} de daño";
        }

        public string moveX(int x)
        {
            return $"El personaje {Name} se movió en el eje X a la posicion {x}";
        }

        public string moveY(int y)
        {
            return $"El personaje {Name} se movió en el eje Y a la posicion {y}";
        }

        public string name => Name;
        public float strength => Strength;
        public float agility => Agility;
        public float magic => Magic;
    }
}
