namespace Web.Domain.Entities
{
    public class PersonajeDeAgilidad : Personaje
    {
        public PersonajeDeAgilidad(string name, float force, float magic, float agility)
        {
            Name = name;
            Force = force;
            Magic = magic;
            Agility = agility;
        }

        public override float CalculateDamage()
        {
            var damage = Force / 2 * Agility * Magic / 2;
            return (damage);
        }
    }
}
