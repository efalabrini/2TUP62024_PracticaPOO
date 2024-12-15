namespace Web.Ej5;

public static class Turno
{
    public static void Atacarse(IList<Personaje> personajes)
    {
        foreach (var personaje in personajes)
        {
            Console.WriteLine(personaje.Atacar());
        }
    }
    public static void MoverFichas(IMoverse ficha, int distanciaX, int distanciaY, string x, string y)
    {
        ficha.MoverseEjeX(distanciaX, x);
        ficha.MoverseEjeY(distanciaY, y);
    }

}