using System;

namespace Web.Ej5;

public class Turno
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
        ficha.MoverseEjeX(4);
        ficha.MoverseEjeY(6);
    }


}
