using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Web.Ej5
{
    public class Enemigo : IMoverse
    {   
        public int life {  get; set; }
        public int level { get; set; }

        public Enemigo(int vida, int nivel) {

            life = vida;
            level = nivel;
                
        }
        public void MoverseEjeX(int distance, string x)
        {
            Console.WriteLine($"El enemigo se movió {distance} pasos hacia la {x}");
        }

        public void MoverseEjeY(int distance, string y)
        {
            Console.WriteLine($"El enemigo se movío {distance} pasos hacia {y}");
        }
    }
}
