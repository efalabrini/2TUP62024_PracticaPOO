using System.Diagnostics.Tracing;

namespace Web.ej3
{
    public class Persona
    {

        public int edad { get; set; }
        public String name { get; set; }


        public Persona(String nombre)
        {
            edad = 0;
            name = nombre;


        }
        public void SetEdad(int years)
        {
            edad = years;
        }



        public virtual String Saludar()
        {
            return "Hola!";
        }
    }
}