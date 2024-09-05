namespace Web.Ej3
{
    public class Persona
    {
        public int Edad { get; set; }
        public string Nombre { get; set; }

        public string Saludo { get; set; }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }
        public void setEdad(int edad) 
        {
            Edad = edad;
        }

        public string Saludar()
        {
            return "Hola";
        }
    }
}
