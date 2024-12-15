namespace Web.Ej5
{
    public class MagicCharacter : Character{
        public MagicCharacter(string Name, float Strength,float Agility, float Magic):base (Name, Strength, Agility, Magic){
        }
        public MagicCharacter(string Name, float Strength,float Agility):base (Name, Strength, Agility, 60){
        }
        public override float CalculateDamage(){
            float x= strength + agility + magic*4;
            return x;
        }
        public override string Attack(){
            return $"{name} hizo {CalculateDamage()} de daño gracias a su magia";;
        }
    }
}