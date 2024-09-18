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

        public int MoverseEjeX()
        {
            return 5;
        }

        public int MoverseEjeY()
        {
            return 5;
        }
    }
}
