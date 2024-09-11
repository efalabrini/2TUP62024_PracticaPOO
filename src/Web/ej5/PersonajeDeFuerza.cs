

using Web.ej5;

public class PersonajeDeFuerza : Personaje{

    public PersonajeDeFuerza(string nombre, double agilidad, double magia, double fuerza = 100):base(nombre,  fuerza, agilidad,  magia){

    }

    public override double CalcularDanio()
    {
        return fuerza*2 + agilidad - magia;
    }

    public override string Atacar(){
            return $"{nombre} hizo {this.CalcularDanio()} daño";
        }
}