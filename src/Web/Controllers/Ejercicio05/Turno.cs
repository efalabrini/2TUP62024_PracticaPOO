namespace Web.Controllers.Ejercicio05
{
    public static class Turno
    {
        public static void Atacarse(IList<Personaje> personajes)
        {
            foreach (var personaje in personajes)
            {
                Console.WriteLine(personaje.Atacar());
            }
        }

        public static void MoverFichas(IMoverse ficha)
        {
            ficha.MoverseEjeX(5); // Ejemplo de movimiento
            ficha.MoverseEjeY(10); // Ejemplo de movimiento
        }
    }
}
