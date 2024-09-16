using Web.Interfaces;

namespace Web.Classes
{
    public class Enemy : Character
    {
        public float Health { get; set; }
        public int Level { get; set; }

        public Enemy(string name, float strength, float agility, float magic,float health,int level) : base(name, strength, agility, magic)
        {
            Health = health;
            Level = level;
        }

        protected override float damageCalculate()
        {
            float damage = (float)((strength * 0.7) + agility + (magic * 5));
            return damage;
        }

        public override string attack()
        {
            return $"El Enemigo {Name} atacó, haciendo {damageCalculate()} de daño";
        }

        public float health => Health;
        public int level => Level;
    }
}