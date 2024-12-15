namespace Web.Ej5
{
    public class Enemigo: IMoverse 
    {
        public int Vida { get; set; }
        public int Nivel { get; set; }

        public void MoverseEjeX(int pasos)
        {
            Console.WriteLine($"Enemigo se movió {pasos} pasos en el eje X.");
        }

        public void MoverseEjeY(int pasos)
        {
            Console.WriteLine($"Enemigo se movió {pasos} pasos en el eje Y.");
        }
    }
}
