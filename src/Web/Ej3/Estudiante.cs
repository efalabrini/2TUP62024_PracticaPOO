using System;

namespace Web.Models
{
    public class Estudiante : Persona
    {
        // Método para estudiar
        public string Estudiar()
        {
            return "Estoy estudiando";
        }

        // Método para saludar, sobrescribiendo el método de Persona
        public override string Saludar()
        {
            return $"Hola soy el estudiante {Nombre}";
        }

        // Método para mostrar la edad (heredado y sobrescrito si necesario)
        public override string MostrarEdad()
        {
            return $"Mi edad es: {edad} años";
        }
    }
}

/* using System;

namespace Web.Ej3;

public class Estudiante : Persona
{
    public string Estudiar()
    {
        return "Estoy estudiando";
    }

    public new string MostrarEdad()
        {
            return $"Mi edad es: {edad} años";
        }

    public new string Saludar()
    {
        return $"Hola, soy el estudiante {Nombre}";
    }
}
 */