using System;

namespace Web.Ej3;

public class Persona
{
    public int Age { get; set; }
    public string Name { get; set; }

    public Persona(string name)
    {
        this.Name = name;
    }

    public virtual string Saludar()
    {
        return $"Hola! {Name}";
    }

    public int SetEdad(int age)
    {
        return Age = age;
    }
}

