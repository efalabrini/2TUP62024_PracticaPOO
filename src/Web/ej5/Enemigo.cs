using Web.ej5;

public class Enemigo : IMoverse{

    public int vida {get;set;}
    public int nivel {get;set;}

    public Enemigo(int vidaIng, int nivelIng){
        vida = vidaIng;
        nivel = nivelIng;
    }

    public string MoverseEjeX(int ejeX){
        return $"El enemigo se movio {ejeX} pasos en el eje X";
    }
    public string MoverseEjeY(int ejeY){
        return $"El enemigo se movio {ejeY} pasos en el eje Y";
    }
}