using System;

namespace Web.Ej5;

public class PersonajeDeFuerza : Personaje, IMoverse
{
    public PersonajeDeFuerza(string nombre, int magia, int agilidad)
    {
        Nombre = nombre;
        Magia = magia;
        Agilidad = agilidad;
        Fuerza = 100;
    }

    public override int CalcularDanio()
    {
        int Estadisticas = (Fuerza * 2) + (Agilidad / 2) + (Magia / 3);
        return Estadisticas;
    }

    public override string Atacar()
    {
        return $"{Nombre} lanza un poderoso golpe con su espada debido a su gran fuerza!";
    }

    public override string DescripcionBatalla()
    {
        return $"{Nombre} está causando estragos con su increíble fuerza!";
    }

     public void MoverseEjeX(int unidades)
    {  
        Console.WriteLine($"{Nombre} se movió {unidades} unidades en el eje X.");
    }

     public void MoverseEjeY(int unidades)
    {
        Console.WriteLine($"{Nombre} se movió {unidades} unidades en el eje X.");
    } 
}
