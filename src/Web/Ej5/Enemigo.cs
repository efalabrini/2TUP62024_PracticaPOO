namespace Web.Ej5;

public class Enemigo : IMoverse
{
    public int Vida { get; set; }
    public int Nivel { get; set; }

    public void MoverseEjeX(int distancia, string x)
    {
        Console.WriteLine($"El enemigo se movió {distancia} pasos hacia la {x}");
    }

    public void MoverseEjeY(int distancia, string y)
    {
        Console.WriteLine($"El enemigo se movió {distancia} lugares hacia {y}");
    }

}