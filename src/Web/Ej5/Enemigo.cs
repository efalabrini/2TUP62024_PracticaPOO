using System;

namespace Web.Ej5;

public class Enemigo:IMoverse
{
    public int Vida {get;set;}
    public int Nivel {get;set;}
    public Enemigo(int _vida,int _nivel)
    {
        Vida=_vida;
        Nivel=_nivel;
    }
}
