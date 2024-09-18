using System;
using Web.Ej1;

namespace Web.Ej3;

public class Estudiante : Persona
{
    public Estudiante (string nombre) : base(nombre)
    {
    }
    public string Estudiar()
    {
        return "estoy estudiando";
    }
    public string MostrarEdad()
    {
        return $"Mi edad es: {Edad} años";
    }
    public override string Saludar()
    {
        return $"Hola, soy el estudiante {Nombre}";
    }


}
