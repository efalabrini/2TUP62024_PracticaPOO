namespace Web.Ej3
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }    
        public int Edad {  get; set; }
        public virtual string Saludar()
        {
            return "Hola soy una persona";
        }

        public Persona(string name)
        {
            Nombre = name;
        }

        public void SetEdad(int edad)
        {
            Edad = edad;
        }
    }
}


