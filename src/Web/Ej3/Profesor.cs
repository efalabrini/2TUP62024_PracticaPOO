namespace Web.Ej3
{
    public class Profesor : Persona
    {
        public Profesor(string name) : base(name) { }

        public string Explicar()
        {
            return "Estoy explicando";
        }

        public string Saludar()
        {
            return $"Hola soy profesor. ({Nombre})";
        }
    }
}
