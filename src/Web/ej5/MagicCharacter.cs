

namespace Web.ej5
{


    public class MagicCharacter : Character
    {

        public MagicCharacter(string name, float strength, float agility, float magic) : base(name, strength, agility, magic) { }
        public MagicCharacter(string name, float strength, float agility) : base(name, strength, agility, 60) { }

        public override float EstimateDamage()
        {
            return Strength + Agility + Magic * 4;
        }

        public override string Attack()
        {
            return $"{Name} hizo {EstimateDamage()} de daño gracias a su magia";
        }




    }
}