using System;

namespace Web.Ej5;

public static class Turno
{   
    public static string Atacarse(IList<Personaje> personajes)
    {
        string retorno="";
        foreach(Personaje personaje in personajes) {
            retorno+=personaje.Atacar()+"\n";
        }
        return retorno;
    }
    public static void MoverFichas(IMoverse ficha){}

}
