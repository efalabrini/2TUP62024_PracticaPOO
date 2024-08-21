

namespace Web.ej1 {

public class Persona{

    public string Name { get; set; }

    public Persona(string Name){
        this.Name = Name;
    }

    public string Saludar(){
        return $"Hola mi nombre es {Name}";
    }

}
}