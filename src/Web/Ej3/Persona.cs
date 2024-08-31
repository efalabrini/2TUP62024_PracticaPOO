using System;

namespace Web.Ej3;

public class Persona
{
    public int age { get; set; }
    protected string name {get;set;}
    public Persona(string _name,int _age)
    {
        name=_name;
        age = _age;
    }


    public Persona(){}


    public void SetEdad(int _age)
    {
        age = _age;
    }

    public string Saludar()
    {
        return "Hola";
    }
}
