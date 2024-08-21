namespace Web.Ej1
{
    public class Person
    {
        public string? Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public string Saludo()
        {
            return $"Hola! mi nombre es {Name}";
        }

    }
}
