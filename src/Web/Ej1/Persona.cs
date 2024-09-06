using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Web.Ej1
{
    public class Persona
    {

        public string? Name{ get; set; }

        public Persona(string name) { 
        
            Name = name;
        }


        public string GetSaludo()
        {
            return $"Hola! mi nombre es {Name}";
        }
    }
}
