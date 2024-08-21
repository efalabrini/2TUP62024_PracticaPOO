namespace Web.Ej1 {
public class Persona {
    //Propiedad
    public string Nombre { get; set; }

    //Metodo constructor
    public Persona(string Nombre) {
        this.Nombre = Nombre;
    }
    //Metodo
    public string Saludar() {
        return $"Hola, mi nombre es {Nombre}";
    }
}
}