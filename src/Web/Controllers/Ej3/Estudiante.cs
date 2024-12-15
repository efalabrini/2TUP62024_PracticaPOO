using Web.Ej3;

public class Estudiante : Persona
{
    public Estudiante(string name) : base(name)
    {
    }

    public string Estudiar()
    {
        return "Estoy estudiando";
    }

    public string MostrarEdad()
    {
        return $"Mi edad es {Age} años";
    }

    public override string Saludar()
    {
        return $"Hola, soy el estudiante {Name}";
    }


}