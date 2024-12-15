namespace Web.Ej5
{
    public class PersonajeDeMagia : Personaje
    {
        public PersonajeDeMagia(string nombre, int fuerza, int agilidad, int magia)
        {
            Nombre = nombre;
            Fuerza = fuerza;
            Agilidad = agilidad;
            Magia = magia;
        }

        public PersonajeDeMagia(string nombre, int fuerza, int agilidad)
        {
            Nombre = nombre;
            Fuerza = fuerza;
            Agilidad = agilidad;
            Magia = 60;
        }

        public override int CalcularDanio()
        {
            return Fuerza + Agilidad + Magia*4;
        }

        public override string Atacar()
        {
            int danio = CalcularDanio();

            return $"{Nombre} hizo {danio} de danio gracias a su magia";
            
        }
    }
}
