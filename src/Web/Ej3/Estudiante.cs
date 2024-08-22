namespace Web.Ej3
{
    public class Estudiante : Persona
    {
        public string Estudiar()
        {
            return ("Estoy estudiando.");
        }

        public override string Saludar()
        {
            return ($"Hola soy el Estudiante {Nombre}");
        }

        public string MostrarEdad()
        {
            return ($"mi edad es: {Edad}");
        }
    }
}
