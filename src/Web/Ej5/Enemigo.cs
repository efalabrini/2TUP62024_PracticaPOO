using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Web.Ej5
{
    public class Enemigo : IMoverse
    {
        public int Vida { get; set; }
        public int Nivel { get; set; }

        public Enemigo(int vida, int nivel) 
        {
            Vida = vida;
            Nivel = nivel;
        }

        public string MoverseEjeX(int distancia)
        {
            return $"el enemigo se movio {distancia} unidades en el eje x";
        }

        public string MoverseEjeY(int distancia)
        {
            return $"el enemigo se movio {distancia} unidades en el eje x";
        }
    }
}
