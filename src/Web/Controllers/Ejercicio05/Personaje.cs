namespace Web.Controllers.Ejercicio05
{
    public abstract class Personaje
    {
        public string Nombre { get; set; }
        public int Fuerza { get; set; }
        public int Agilidad { get; set; }
        public int Magia { get; set; }

        protected Personaje(string nombre, int fuerza, int agilidad, int magia)
        {
            Nombre = nombre;
            Fuerza = fuerza;
            Agilidad = agilidad;
            Magia = magia;
        }

        public abstract int CalcularDanio();
        public virtual string Atacar()
        {
            int danio = CalcularDanio();
            return $"{Nombre} hizo {danio} de daño";
        }
    }
}
