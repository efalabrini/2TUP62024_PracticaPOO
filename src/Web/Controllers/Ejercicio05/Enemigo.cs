namespace Web.Controllers.Ejercicio05
{
    public class Enemigo:IMoverse
    {
        public int Vida { get; set; }
        public int Nivel { get; set; }

        public Enemigo(int vida, int nivel)
        {
            Vida = vida;
            Nivel = nivel;
        }

        public void MoverseEjeX(int unidades)
        {
          
        }

        public void MoverseEjeY(int unidades)
        {
            
        }
    }
}
