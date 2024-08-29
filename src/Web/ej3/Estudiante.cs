
using Web.ej3;

public class Estudiante : Persona{

    public Estudiante(string nombre):base(nombre){
        
    }

    public string Estudiar(){
        return "Estoy estudiando";
    }

    public string MostrarEdad(){
        return $"Mi edad es {edad}";
    }

     public override string Saludar()
    {
        return $"Hola soy el estudiante {nombre}";
    }
}