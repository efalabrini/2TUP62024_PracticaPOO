namespace Web.Ej3
{
    public class Profesor : Persona
    {
        public override string Saludar()
        {
            return ($"Hola soy el Profesor {Nombre}");
        }
        public string Explicando()
        {
            return ("Estoy explicando.");
        }
    }
}
