namespace Web.ej3
{
    public class Estudiante : Persona
    {
        public Estudiante(String nombre) : base(nombre) { }
        public String Estudiar()
        {
            return "Estoy estudiando!";
        }

        public String MostrarEdad()
        {
            return $"Mi edad es {edad}!";
        }

        public override String Saludar()
        {
            return $"Hola, soy el estudiante {name}!";
        }
    }
}