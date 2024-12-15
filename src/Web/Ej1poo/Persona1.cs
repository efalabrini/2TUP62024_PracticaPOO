namespace Web.Ej1poo;

public class Persona {
    public string? Nombre {get;set;}
    public Persona (string nombre){
        Nombre = nombre;
    }
    public string GetSaludo(){
        return $"Hola! mi nombre es {Nombre}.";
    }
}