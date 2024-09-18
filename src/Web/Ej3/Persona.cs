namespace Web.Ej3

{
    public class Persona
    {
        public int edad;
        public required string Nombre { get; set; }

        public string Saludar() 
        {
            return "Hola";
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }
    }

}