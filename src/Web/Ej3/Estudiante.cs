namespace Web.Ej3
{
    public class Estudiante : Persona
    {
        public Estudiante(string nombre) : base(nombre) { }
        

        public string Estudiando()
        {
            return "Estoy estudiando";
        }

        public string MostrarEdad()
        {
            return $"Mi edad es: {Edad} años";
        }

        public override string Saludar() 
        {
            return $"Hola, soy el estudiante {Nombre}";
        }
    }
}
