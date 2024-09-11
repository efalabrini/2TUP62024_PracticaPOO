namespace Web.Ej5
{
    public class AgilityCharacter : Character{
        public AgilityCharacter(string Name,float Strength,float Agility, float Magic ):base(Name, Strength, Agility, Magic){
        }
        public override float  CalculateDamage(){
            float x= strength/2 * agility * magic/2;
            return x;
        }
    }
}