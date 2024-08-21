namespace Web.Ej3
{
    public class Persona
    {
        public int Edad { get; private set; }
        public string Nombre { get; set; }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }
        public virtual string Saludar()
        {
            return $"Hola, me llamo {Nombre}";
        }

        public void SetEdad(int edad)
        {
            Edad = edad;
        }

    }
}
