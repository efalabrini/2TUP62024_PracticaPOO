using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Web.Ej3
{
    public class Persona
    {
        public Persona(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual string Saludar()
        {
            return ($"Hola! {Name}");
        }
        public void SetEdad(int age)
        {
            Age = age;
        }

    }
}
