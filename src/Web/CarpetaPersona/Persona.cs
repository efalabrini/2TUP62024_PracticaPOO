namespace Web.CarpetaPersona;

public class Persona
{
    public string Name { get; set; }

    public Persona (string name)
    {
        Name = name;
    } 

    public string getSaludo()
    {
        return ($"Hola mi nombre es {Name}");
    }
}