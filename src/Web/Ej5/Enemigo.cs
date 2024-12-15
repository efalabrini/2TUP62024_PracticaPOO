namespace Web.Ej5
{
    public class Enemigo : IMoverse
    {
        public int Vida { get; set; }
        public int Nivel { get; set; }

        public string MoverseEjeX()
        {
            return "Se movio en el vertice X";
        }

        public string MoverseEjeY()
        {
            return "Se movio en el vertice Y";
        }
    }
}
