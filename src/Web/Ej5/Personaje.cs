namespace Web.Ej5
{
    public abstract class Personaje
    {
        public string Nombre { get; set; } = string.Empty;
        public int Fuerza { get; set; }
        public int Agilidad { get; set; }
        public int Magia { get; set; }

        public abstract int CalcularDanio();
        public virtual string Atacar()
        {
            int danio = CalcularDanio();
            return $"{Nombre} hizo {danio} de daño";
        }
    }
}
