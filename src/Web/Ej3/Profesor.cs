namespace Web.Ej3
{
    public class Profesor : Person
    {
        public Profesor(string Name) : base(Name)
        {
            name = Name;

        }

        public string Explain()
        {
            return "Estoy explicando.";
        }

        public override string sayHi()
        {
            return $"Hola soy el profesor {name}";
        }
    }
}

