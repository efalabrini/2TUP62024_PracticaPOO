using Web.Ej5;

namespace Web.Ej5
{
    public abstract class Personaje: IMoverse
    {
        public string ?Nombre { get; set; }
        public int Fuerza { get; set; }
        public int Agilidad { get; set; }
        public int Magia { get; set; }

        public abstract int CalcularDanio();

        public virtual string Atacar()
        {
            int danio = CalcularDanio();
            return $"{Nombre} hizo {danio} de daño";
        }

        public void MoverseEjeX(int pasos)
        {
            Console.WriteLine($"{Nombre} se movió {pasos} pasos en el eje X.");
        }

        public void MoverseEjeY(int pasos)
        {
            Console.WriteLine($"{Nombre} se movió {pasos} pasos en el eje Y.");
        }
    }
}
