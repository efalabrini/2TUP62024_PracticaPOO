namespace Web.Ej5
{
    public static class Turno
    {
        public static string Atacarse(IList<Personaje> personajes)
        {
            var resultadoBatalla = new List<string>();

            foreach (var personaje in personajes)
            {
                resultadoBatalla.Add(personaje.Atacar());
            }

            return string.Join("\n", resultadoBatalla);
        }

        public static string MoverFichas(IMoverse ficha)
        {
            ficha.MoverseEjeX();
            ficha.MoverseEjeY();

            return "Ficha movida en los ejes X e Y.";
        }
    }
}
