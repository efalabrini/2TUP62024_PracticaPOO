namespace Web.Ej3
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad;

        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        public void SetEdad(int edad)
        {
            Edad = edad;
        }

        public virtual string Saludar()
        {
            return $"Hola soy {Nombre}";
        }
    }
}
