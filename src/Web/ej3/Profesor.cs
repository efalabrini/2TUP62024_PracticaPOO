

using Web.ej3;

public class Profesor : Persona{

    public Profesor(string nombre):base(nombre){
        
    }

    public string Explicar(){
        return "Estoy explicando";
    }

    public override string Saludar()
    {
        return $"Hola soy el profesor {nombre}";
    }
}