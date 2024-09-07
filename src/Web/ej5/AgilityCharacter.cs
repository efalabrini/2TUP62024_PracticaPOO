

namespace Web.ej5
{


    public class AgilityCharacter : Character
    {

        public AgilityCharacter(string name, float strength, float agility, float magic) : base(name, strength, agility, magic) { }

        public override float EstimateDamage()
        {
            return Strength / 2 * Agility * Magic / 2;
        }



    }
}