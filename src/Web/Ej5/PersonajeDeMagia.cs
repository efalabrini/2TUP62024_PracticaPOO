using System;

namespace Web.Ej5;

public class PersonajeDeMagia : Personaje,IMoverse
{
    public PersonajeDeMagia(string _nombre, int _fuerza, int _agilidad,int _magia):base(_nombre,_fuerza,_agilidad,_magia)
    {

    }
    public PersonajeDeMagia(string _nombre, int _fuerza, int _agilidad):base(_nombre,_fuerza,_agilidad,60)
    {

    }
    public override float CalcularDanio(){
        return Fuerza+Agilidad+Magia*4;
    }
    public override string Atacar(){
        return $"{Nombre} hizo {this.CalcularDanio()} de daño gracias a su magia";
    }
}
