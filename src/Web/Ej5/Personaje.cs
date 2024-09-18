using System;

namespace Web.Ej5;

public abstract class Personaje
{
    public string Nombre {get;set;}
    public int Fuerza {get;set;}
    public int Agilidad {get;set;}
    public int Magia {get;set;}
    public Personaje(string _nombre, int _fuerza, int _agilidad,int _magia){
        Nombre=_nombre;
        Fuerza=_fuerza;
        Agilidad=_agilidad;
        Magia=_magia;
    }
    public abstract float CalcularDanio();
    public virtual string Atacar()
    {
        return $"{Nombre} hizo {this.CalcularDanio()} de daño";
    }
    

}
