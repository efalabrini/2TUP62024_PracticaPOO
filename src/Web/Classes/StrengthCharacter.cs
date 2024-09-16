using System.Security.Cryptography.X509Certificates;

namespace Web.Classes
{
    public class StrengthCharacter : Character
    {
        public StrengthCharacter(string name, float agility, float magic) : base(name,100, agility, magic)
        {
        }

        protected override float damageCalculate()
        {
            float damage = (agility + magic) * strength;
            return damage;
        }
    }
}
