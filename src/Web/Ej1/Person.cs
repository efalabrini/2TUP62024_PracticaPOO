namespace Web.Ej1
{
    public class Person
    {
        public string Name { get; set; }

        public string Saludo()
        {
            return $"Hola, me llamo {Name} ;)";
        }

        public Person(string name)
        {
            Name = name ;
        }

    }
    
}
