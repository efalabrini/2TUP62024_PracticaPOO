
public class Estudiante : Persona
{
    public Estudiante(string nombre) : base(nombre) { }

    public string Estudiar()
    {
        return "Estoy estudiando";
    }

    public override string Saludar()
    {
        return $"Hola soy el estudiante {Nombre}";
    }

    public string MostrarEdad()
    {
        return $"Mi edad es: {Edad} años"; 
    }
}
