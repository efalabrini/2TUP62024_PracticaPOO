using System;

namespace Web.Ej1;

public class Persona
{
        public string Nombre {get;set;}

            public string GetSaludo()
        {
            return $"Hola! mi nombre es {Nombre}.";
        }    
}
