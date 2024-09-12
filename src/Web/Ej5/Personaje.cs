using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Web.Ej5
{
    public abstract class Personaje : IMoverse
    { 
        public string? Name {  get; set; }
        public int Force { get; set; }
        public int Agility{ get; set; }
        public int Magic { get; set; } 

     

        public abstract int CalcularDanio();

        public virtual string Atacar()
        {
            return $"{Name} hizo {CalcularDanio()} de daño.";
        }

        public void MoverseEjeX(int distance, string x)
        {
            Console.WriteLine($"{Name} se movió {distance} pasos hacia la {x}");
        }

        public void MoverseEjeY(int distance, string y)
        {
            Console.WriteLine($"{Name} se movío {distance} pasos hacia {y}");
        }
    }

}
