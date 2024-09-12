using Microsoft.AspNetCore.Mvc;


namespace Web.Ej3
{

    public class Estudiante : Persona
    {
 
        public Estudiante(string name) : base(name) { }

        public string Estudiar() 
        {
            return "Estoy estudiando";
        }

        public string MostrarEdad()
        {
            return $"Mi edad es {Edad}";
        }

        public string Saludar()
        {
            return $"Hola soy estudiante {Nombre}";
        }
    }
}
