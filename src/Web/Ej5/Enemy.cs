namespace Web.Ej5
{
    public class Enemy : IMove{
        public float life{get;set;}
        public int level{get;set;}

        public Enemy(float Life,int Level){
            life=Life;
            level=Level;
        }
        public string MoveXAxis(int distance, string x){
            return $"El enemigo se movio {distance} lugares hacia la {x}";
        }
        public string MoveYAxis(int distance, string y){
            return $"El enemigo se movio {distance} lugares hacia la {y}";
        }
    }
}