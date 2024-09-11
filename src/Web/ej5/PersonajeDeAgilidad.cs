using Web.ej5;

public class PersonajeDeAgilidad : Personaje {

    public PersonajeDeAgilidad(string nombre, double agilidad, double magia, double fuerza):base(nombre,  fuerza, agilidad,  magia){

    }

    public override double CalcularDanio(){
        return fuerza/2*agilidad*magia/2 ;
    }


    public override string Atacar(){
            return $"{nombre} hizo {this.CalcularDanio()} daño";
        }
}