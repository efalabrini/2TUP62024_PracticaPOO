using System.Text.Json.Serialization;

namespace Web.Domain.Entities
{
    public class PersonajeDeFuerza : Personaje
    {
        public PersonajeDeFuerza() 
        {
            Force = 100;
        }
        public PersonajeDeFuerza(string name, float magic, float agility)
        {
            Name = name; 
            Magic = magic;
            Agility = agility;
            Force = 100;
        }

        [JsonIgnore]
        public override float Force { get; set; }

        public override float CalculateDamage()
        {
            var damage = Force / Magic + Agility;
            return damage;
        }
    }
}
