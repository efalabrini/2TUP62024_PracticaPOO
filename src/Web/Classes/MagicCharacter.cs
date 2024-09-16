using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Web.Classes
{
    public class MagicCharacter : Character
    {
        public MagicCharacter(string name, float strength, float agility, float magic) : base(name, strength, agility, magic)
        {
        }

        public MagicCharacter(string name, float strength, float agility) : base(name, strength, agility,60)
        {
            
        }

        protected override float damageCalculate()
        {
            float damage = strength + agility + magic * 4;
            return damage;
        }

        public override string attack()
        {
            return $"{name} hizo {damageCalculate()} de daño gracias a su magia";
        }
    }
}