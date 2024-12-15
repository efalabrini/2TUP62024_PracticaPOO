namespace Web.ej3
{
    public class Profesor : Persona
    {
        public Profesor(String nombre) : base(nombre) { }
        public String Explicar()
        {
            return "Estoy explicando!";
        }


        public override String Saludar()
        {
            return $"Hola, soy el profesor {name}!";
        }
    }
}