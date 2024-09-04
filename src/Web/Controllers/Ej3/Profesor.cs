using Web.Ej3;

public class Profesor : Persona
{
    public Profesor(string name) : base(name)
    {
    }
    public string Explicar()
    {
        return "Estoy explicando";
    }

    public override string Saludar()
    {
        return $"Hola, soy el profesor {Name}";
    }
}