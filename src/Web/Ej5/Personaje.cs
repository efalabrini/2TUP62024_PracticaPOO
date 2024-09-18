using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Web.Ej5
{
    public abstract class Personaje : IMoverse
    {
        public string Nombre { get; set; }
        public int Fuerza { get; set; }
        public int Agilidad { get; set; }
        public int Magia { get; set; }

        public abstract int CalcularDanio();
       

        public virtual string Atacar() 
        {
            int danio = CalcularDanio();
            return($"{Nombre} hizo {danio} de daño");
        }
        public int MoverseEjeX()
        {
            return 10; 
        }

        public int MoverseEjeY()
        {
            return 10;
        }
    }
}
