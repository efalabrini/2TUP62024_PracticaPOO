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
        public static void MoverFichas(IMoverse fichas) 
        {
            fichas.MoverseEjeX(3);
            fichas.MoverseEjeY(8);
        }


    }
}
