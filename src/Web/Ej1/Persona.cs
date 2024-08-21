namespace Web;

public class Persona
{
    public string Nombre { get; set; }

    public Persona(string nombre)
    { 
        Nombre = nombre;
    }

    public string GetSaludo()
    {
        return $"Hola mi nombre es {Nombre}";
    }

    public static List<string> ObtenerNombres(List<Persona> personas)
    {
        List<string> nombres = new List<string>();

        foreach (var persona in personas)
        {
            nombres.Add(persona.Nombre);
        }

        return nombres;
    }
}