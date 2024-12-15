namespace Web.Ej5
{
    public class StrengthCharacter : Character{
        public StrengthCharacter(string Name,float Agility, float Magic, float Strength=100):base(Name, Strength, Agility, Magic){
        }
        public override float CalculateDamage(){
            float x=strength/2 * (agility+magic/2);
            return x;
        }
    }
}