﻿using System.Reflection.Metadata.Ecma335;

namespace Web.Ej1;

public class Persona
{
    public string? Nombre { get; set; }

    public Persona(string nombre)
    {
        Nombre = nombre;
    }

    public string GetSaludo()
    {
        return $"Hola! mi nombre es {Nombre}";
    }
}