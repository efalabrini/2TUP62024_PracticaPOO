using System.Xml.Linq;

namespace Web.Ej3
{
    public class Student : Person
    {
        public Student(string Name) : base(Name)
        {
            name = Name;
        }


        public string Studying()
        {
            return "Estoy estudiando.";
        }

        public override string sayHi()
        {
            return $"Hola, soy el estudiante {name}";
        }

        public string showAge()
        {
            return $"Mi edad es {age}";

        }


    }
}
