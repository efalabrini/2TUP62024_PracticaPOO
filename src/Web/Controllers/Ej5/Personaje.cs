namespace Web.Ej5;
public abstract class Personaje : IMoverse
{
    public string? Nombre {get; set;}
    public int Fuerza {get; set;}
    public int Agilidad {get; set;}
    public int Magia {get; set;}

    public abstract int CalcularDanio();
    
    public virtual string Atacar()
    {
        return $"{Nombre} hizo {this.CalcularDanio()} de daño";
    }

    public void MoverseEjeX(int distancia, string x)
    {
        Console.WriteLine($"{Nombre} se movió {distancia} pasos hacia la {x}");
    }

    public void MoverseEjeY(int distancia, string y)
    {
        Console.WriteLine($"{Nombre} se movío {distancia} pasos hacia {y}");
    }
}