


namespace Web.ej5
{
    public class StrengthCharacter : Character
    {

        public StrengthCharacter(string name, float agility, float magic, float strength = 100) : base(name, strength, agility, magic) { }


        public override float EstimateDamage()
        {
            return Strength * Magic - Agility;
        }




    }
}