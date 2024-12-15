using System;

namespace Web.Ej3;

public class Profesor : Persona
{
    public Profesor(string _name, int _edad):base(_name,_edad)
    {
        
    }

    public string Explicar(){
        return "Estoy explicando";
    }
    public string Saludar(){
        return $"Hola soy el profesor {name}";
    }
}
