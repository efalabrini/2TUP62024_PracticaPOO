namespace Web.ej5
{


    public class Enemy : IMove
    {
        public float Life { get; set; }
        public int Level { get; set; }

        public Enemy(float life, int level)
        {
            Life = life;
            Level = level;
        }

        public string MoveAxisX(int steps)
        {
            return $"El enemigo se ha movido {((steps == 1) ? "1 paso" : $"{steps} pasos")}) en el eje x";
        }
        public string MoveAxisY(int steps)
        {
            return $"El enemigo se ha movido un paso en el eje y";

        }
    }
}