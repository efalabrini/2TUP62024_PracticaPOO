using System;

namespace Web.Ej5;

public class PersonajeDeAgilidad : Personaje,IMoverse
{
    public PersonajeDeAgilidad(string _nombre, int _fuerza, int _agilidad,int _magia):base(_nombre,_fuerza,_agilidad,_magia)
    {

    }
    public override float CalcularDanio(){
        return Fuerza/2*Agilidad*Magia/2;
    }
}
