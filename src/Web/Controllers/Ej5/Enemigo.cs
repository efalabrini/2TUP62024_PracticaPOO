using Web.Ej5;

public class Enemigo : IMoverse
{
    public int Vida {get; set;}
    public int Nivel {get; set;}
    public Enemigo(int vida, int nivel)
    {
        Vida = vida;
        Nivel = nivel;
    }
    public void MoverseEjeX(int distancia, string x)
    {
        Console.WriteLine($"El enemigo se movió {distancia} pasos hacia la {x}");
    }

    public void MoverseEjeY(int distancia, string y)
    {
        Console.WriteLine($"El enemigo se movío {distancia} pasos hacia la {y}");
    }
}