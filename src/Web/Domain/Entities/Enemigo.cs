using System.Text.Json.Serialization;
using Web.Domain.Interfaces;

namespace Web.Domain.Entities
{
    public class Enemigo : IMoverse
    {
        public Enemigo() { }
        public float HealtPoints {  get; set; } 
        public int Level { get; set; }

        public string MoverseEjeX()
        {
            return "The enemy moved on the X' axis.";
        }

        public string MoverseEjeY()
        {
            return "The enemy moved on the Y' axis.";
        }

        public string ReciveDamage(float damage)
        {
            HealtPoints -= damage;
            if (HealtPoints <= 0)
            {
                return "The enemy is dead";
            }
            return $"The enemy recive {damage} of damage. \nHP left: {HealtPoints}";
        }

        public Enemigo (int level)
        {
            Level = level;
            HealtPoints = 100 * Level;
        }
    }
}
