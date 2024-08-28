namespace Web.Ej3
{
    public class Persona
    {
        public string? Nombre { get; set; }
        public int Edad { get; set; }

        public virtual string Saludar()
        {
            return $"Hola soy {Nombre}";
        }

        public void SetEdad(int edad)
        {
            Edad = edad;
        }
    }
}
