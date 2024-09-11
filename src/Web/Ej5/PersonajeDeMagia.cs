namespace Web.Ej5
{
    public class PersonajeDeMagia : Personaje
    {
        public PersonajeDeMagia(string nombre, float magia, float fuerza, float agilidad) : base(nombre, fuerza, agilidad, magia) { }
        public PersonajeDeMagia(string nombre, float fuerza , float agilidad) : base(nombre, fuerza, agilidad, 60) { }

        public override float CalcularDanio()
        {
            return Fuerza + Agilidad + Magia * 4 ;
        }

        public override string Atacar()
        {
            return $"{Nombre} hizo {CalcularDanio()} de daño gracias a su magia";
        }
    }
}
