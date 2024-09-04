using Microsoft.AspNetCore.Mvc;

namespace Web.Ej3
{
    public class Persona
    {
        public int Edad {  get; set; }
        public string? Nombre { get; set; }

        public  virtual string Saludar() 
        {
            return ($"Hola soy {Nombre}");
        }

        public void SetEdad(int edad) {
            Edad = edad;
        }

    }
}
