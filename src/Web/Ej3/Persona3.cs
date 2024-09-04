namespace Web.Ej3
{
    public class Persona
    {
        public string Nombre { get; set; }
        protected int Edad { get; set; }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        public virtual string Saludar()
        {
            return $"Hola, soy {Nombre}.";
        }

        public void SetEdad(int edad)
        {
            Edad = edad;
        }
    }
}