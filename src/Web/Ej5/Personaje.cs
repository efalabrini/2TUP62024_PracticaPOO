namespace Web.Ej5
{
    public abstract class Personaje : IMoverse
    {
        public string? Nombre { get; set; }
        public int Fuerza { get; set; }
        public int Agilidad { get; set; }
        public int Magia { get; set; }

        public abstract int CalcularDanio();

        public virtual string Atacar()
        {
            int danio = CalcularDanio();
            return $"{Nombre} hizo {danio} de danio";
        }


        public string MoverseEjeX(int distancia) 
        {
            return $"{Nombre} se movio {distancia} unidades en el eje x";
        }

        public string MoverseEjeY(int distancia)
        {
            return $"{Nombre} se movio {distancia} unidades en el eje y";
        }


    }
}
