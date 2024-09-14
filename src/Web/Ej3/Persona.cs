namespace Web.Ej3
{
    public class Persona
    {
        public int Edad { get; set; }
        public string Nombre { get; set; }

        public Persona()
        {

        }
        public Persona(int edad, string nombre)
        {
            Edad = edad;
            Nombre = nombre;
        }
        public string Saludar() { return "Hola"; }

        public int SetEdad(int edad)
        {
            Edad = edad;
            return Edad;
        } 

    }
}
