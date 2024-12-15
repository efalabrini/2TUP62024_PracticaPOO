using Web.Interfaces;

namespace Web.Ej5
{
    public class Enemigo : IMoverse
    {
        public float Vida { get; set; }
        public int Nivel { get; set; }

        public Enemigo(float vida, int nivel)
        {
            Vida = vida;
            Nivel = nivel;
        }

        public string MoverseEjeX(int pasos)
        {
            return $"El enemigo se ha movido {((pasos == 1) ? "1 paso" : $"{pasos} pasos")}) en el eje X";
        }

        public string MoverseEjeY(int pasos) 
        {
            return $"El enemigo se ha movido un pas en el eje Y";
        }
    }
}
