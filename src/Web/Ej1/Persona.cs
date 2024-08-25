using System.ComponentModel.DataAnnotations;

namespace Web.Ej1
{
    public class Persona
    {
        public Persona(string name  ) 
        {
            Name = name;
        }
        public string? Name { get; set; }

        public string GetGreeting(string name)
        {
            return ($"Hello, my name is {name}.");
        }
    }
}
