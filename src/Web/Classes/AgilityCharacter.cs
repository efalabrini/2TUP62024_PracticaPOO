namespace Web.Classes
{
    public class AgilityCharacter : Character
    {
        public AgilityCharacter(string name, float strength, float agility, float magic) : base(name, strength, agility, magic)
        {

        }

        protected override float damageCalculate()
        {
            float damage = strength / 2 * agility * magic / 2;
            return damage;
        }
    }
}
