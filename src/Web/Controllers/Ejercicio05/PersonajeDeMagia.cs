namespace Web.Controllers.Ejercicio05
{
    public class PersonajeDeMagia:Personaje
    {
        public PersonajeDeMagia(string nombre, int fuerza, int agilidad, int magia = 60)
            : base(nombre, fuerza, agilidad, magia)
        {
        }

        public override int CalcularDanio()
        {
            return Fuerza + Agilidad + Magia * 4;
        }

        public override string Atacar()
        {
            int danio = CalcularDanio();
            return $"{Nombre} hizo {danio} de daño gracias a su magia";
        }
    }
}
