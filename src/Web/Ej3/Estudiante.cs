namespace Web.Ej3
{
    public class Estudiante : Persona 
    {

        public Estudiante(int edad, string nombre) : base(edad, nombre)
        {
            
        }

        public string Estudiar() { return "Estoy estudiando"; }

        public string MostrarEdad()
        {
            return $"Mi edad es: {Edad} años";
        }
        public string Saludar() { return $"Hola soy el estudiante {Nombre}"; }


    }
}
