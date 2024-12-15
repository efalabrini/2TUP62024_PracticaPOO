using System;

namespace Web.Ej3;

public class Estudiante : Persona
{

    public Estudiante(string _name,int _age):base(_name,_age)
    {

    }
    public string Saludar(){
        return $"Hola soy el estudiante {name}";
    }
    public string Estudiar(){
        return "Estoy estudiando";
    }
    public string MostrarEdad(){
        return $"Mi edad es {age}";
    }
}
