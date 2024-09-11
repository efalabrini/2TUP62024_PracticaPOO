namespace Web.Ej5
{
    public abstract class Character: IMove{
        public string? name {get;set;}
        public float strength {get;set;}
        public float agility {get;set;}
        public float magic {get;set;}

        public Character(string Name, float Strength, float Agility, float Magic)
        {
            name = Name;
            strength = Strength;
            agility = Agility;
            magic = Magic;
        }

        public abstract float CalculateDamage();
        public virtual string Attack(){
            float x=CalculateDamage();
            return $"{name} hizo {x} de daño";
        }
        public string MoveXAxis(int distance, string x){
            return $"{name} se movio {distance} lugares hacia la {x}";
        }
        public string MoveYAxis(int distance, string y){
            return $"{name} se movio {distance} lugares hacia la {y}";
        }
    }   
}