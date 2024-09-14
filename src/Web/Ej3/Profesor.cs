namespace Web.Ej3
{
    public class Profesor : Persona
    {
        public Profesor(int edad, string nombre) : base(edad, nombre)
        {

        }
        public string Explicar()
        {
            return "Estoy explicando";
        }

        public string Saludar() { 
            return $"Hola soy el profesor {Nombre}"; 
        }
    }
}
