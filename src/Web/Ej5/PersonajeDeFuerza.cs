using System;

namespace Web.Ej5;

public class PersonajeDeFuerza : Personaje,IMoverse
{
    public PersonajeDeFuerza(string _nombre, int _agilidad,int _magia) : base(_nombre,100,_agilidad,_magia)
    {

    }
    public override float CalcularDanio(){
        return Fuerza*Magia+Agilidad;
    }
    
}
