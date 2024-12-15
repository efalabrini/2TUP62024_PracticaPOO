namespace Web.Ej5;

public abstract class Personaje : IMoverse
{
    protected string? Nombre { get; set; }
    protected int Fuerza { get; set; }
    protected int Agilidad { get; set; }
    protected int Magia { get; set; }

    public abstract int CalcularDanio();
    public virtual string Atacar()
    {
        return $"{Nombre} hizo {this.CalcularDanio()} de daño.";
    }

    public void MoverseEjeX(int distancia, string x)
    {
        Console.WriteLine($"{Nombre} se movió {distancia} pasos hacia la {x}");
    }

    public void MoverseEjeY(int distancia, string y)
    {
        Console.WriteLine($"{Nombre} se movió {distancia} lugares hacia {y}");
    }

}