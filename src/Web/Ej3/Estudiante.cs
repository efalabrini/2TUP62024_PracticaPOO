namespace Web.Ej3

{
    public class Estudiante : Persona
    {
        public string Estudiar() 
        {
            return "Estoy estudiando";

        }
        
        public string MostrarEdad()
        {
            return $"Mi edad es: {edad} años";
        }
        
        public new string Saludar()
        {
            return $"Hola soy el estudiante {Nombre}";
        }
    }
}