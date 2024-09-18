using System;

namespace Web.Ej3;

public class Persona
{
    public string Nombre {get; set;}
    public int Edad{get; set;}

    public Persona( string nombre) //constructor
    {
        Nombre=nombre;
    }
    public virtual string Saludar() //virtual=sobreescrito
    {
        return $"Hola soy {Nombre}";
    }
    public void SetEdad(int edad) 
    {
        Edad=edad;
    }
}
