using Web.Interfaces;

namespace Web.Ej5
{
    public static class Turno
    {
        public static IEnumerable<string> Attacarse(IList<Personaje> personajes)
        {
            return personajes.Select(personaje => personaje.Atacar());
        }

        public static void MoverFichas(IMoverse ficha)
        {
            Random random = new Random();
            ficha.MoverseEjeX(random.Next(0, 15));
            ficha.MoverseEjeY(random.Next(0, 15));
        }

    }
}