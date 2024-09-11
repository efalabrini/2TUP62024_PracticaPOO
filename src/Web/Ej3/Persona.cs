namespace Web.Models
{
    public class Persona
    {
        public string Nombre { get; set; }
        protected int edad; // Accesible en clases derivadas

        // Método para saludar
        public virtual string Saludar()
        {
            return $"Hola soy {Nombre}";
        }

        // Método para establecer la edad
        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        // Método para mostrar la edad
        public virtual string MostrarEdad()
        {
            return $"Mi edad es: {edad} años";
        }
    }
}



/* using System;

namespace Web.Ej3;

public class Persona
{
    public string Nombre { get; set; }
   protected int edad;
    public string Saludar()
    {
        return $"Hola, soy {Nombre}";
    }

    public int SetEdad(int edad)
    {
        return edad;
    }

     public string MostrarEdad()
        {
            return $"Mi edad es: {edad} años";
        }
} */
