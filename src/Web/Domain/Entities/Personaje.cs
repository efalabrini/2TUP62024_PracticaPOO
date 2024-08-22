using Web.Domain.Interfaces;

namespace Web.Domain.Entities
{
    public abstract class Personaje : IMoverse
    {

        public string Name { get; set; }
        public virtual float Force{ get; set; }
        public float Agility{ get; set; }
        public virtual float Magic { get; set; }

        public virtual float CalculateDamage()
        {
            return 0;
        }
        public virtual string Atack(float damage)
        {
            return $"The character {Name} did an attack of {damage} points of damage to the enemy!";
        }

        public string MoverseEjeX()
        {
            return "The character moved on the X' axis.";
        }

        public string MoverseEjeY()
        {
            return "The character moved on the Y' axis.";
        }

    }
}
