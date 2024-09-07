
namespace Web.ej5
{
    public abstract class Character : IMove
    {
        public string Name { get; set; }
        public float Strength { get; set; }
        public float Agility { get; set; }
        public float Magic { get; set; }

        public Character(string name, float strength, float agility, float magic)
        {
            Name = name;
            Strength = strength;
            Agility = agility;
            Magic = magic;
        }

        public abstract float EstimateDamage();
        public virtual string Attack()
        {
            return $"{Name} hizo {EstimateDamage()} de daño";
        }


        public string MoveAxisX(int steps)
        {
            return $"El {Name} se ha movido {((steps == 1) ? "1 paso" : $"{steps} pasos")}) en el eje x";
        }
        public string MoveAxisY(int steps)
        {
            return $"El {Name} se ha movido un paso en el eje y";


        }

    }
}
