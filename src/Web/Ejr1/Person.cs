

namespace Web.Ejr1
{
    public class Person
    {
        public string? name { get; set; }
       
        public Person(string name)
        {
            this.name = name;
        }
        public string GetSaludo()
        {
            return $"hola! tu nombre es {name}";
        }
       

    }
}



