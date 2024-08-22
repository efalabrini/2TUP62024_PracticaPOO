namespace Web.Domain.Entities
{
    public class PersonajeDeMagia : Personaje
    {
        public PersonajeDeMagia() { }
        public PersonajeDeMagia(string name, float force, float agility, float magic )
        {
            Name = name;
            Force = force;
            Agility = agility;
            Magic = magic;
        }

        public PersonajeDeMagia(string name, float force, float agility) : this(name, force, agility, 60){ }

        public override float CalculateDamage()
        {
            var damage = Force + Agility + Magic * 4;
            return (damage);
        }
        public override string Atack(float damage)
        {
            return $"The character {Name} did an attack of {damage} points of damage thanks to his magic";
        }
    }
}
