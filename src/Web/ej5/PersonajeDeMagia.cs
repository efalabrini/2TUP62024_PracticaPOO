using Web.ej5;


public class PersonajeDeMagia : Personaje{

    public PersonajeDeMagia(string nombre, double agilidad, double magia, double fuerza):base(nombre,  fuerza, agilidad,  magia){

    }

    public PersonajeDeMagia(double fuerza, string nombre, double agilidad, double magia = 60):base(nombre,  fuerza, agilidad,  magia){

    }


    public override double CalcularDanio(){
        return fuerza+agilidad+magia*4;
    }


    public override string Atacar(){
            return $"{nombre} hizo {this.CalcularDanio()} daño gracias a su magia";
        }
}