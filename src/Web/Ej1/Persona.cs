namespace Web.Ej1
{
    public class Persona
    {
        public string Name { get; set; }

        public string GetSaludo(string name)
        {
            return ($"Hola, mi nombre es {name}");
        }
    }
}

/*
 Crear un endpoint que reciba tres nombres de personas y retorne una lista con el saludo de cada persona.
Para ello, crear una clase Persona que tenga una propiedad Nombre de tipo string. 
Además la clase debe tener un método llamado GetSaludo, devuelva el siguiente resultado: "Hola! mi nombre es {Nombre}."

 */