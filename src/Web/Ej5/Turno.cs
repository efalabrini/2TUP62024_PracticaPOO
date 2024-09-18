namespace Web.Ej5
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
            Console.WriteLine($"Movimiento en X: {ficha.MoverseEjeX()}");
            Console.WriteLine($"Movimiento en Y: {ficha.MoverseEjeY()}");
        }
    }
}
