using System;

namespace Web.Models
{
    public class Profesor : Persona
    {
        
        public string Explicar()
        {
            return "Estoy explicando";
        }

        
        public override string Saludar()
        {
            return $"Hola soy el profesor {Nombre}";
        }
    }
}