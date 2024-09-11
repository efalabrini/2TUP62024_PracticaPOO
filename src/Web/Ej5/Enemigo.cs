using System;

namespace Web.Ej5;

public class Enemigo : IMoverse
{
    public int Vida { get; set;}
    public int Nivel {get; set;}


    public Enemigo(int vida, int nivel)
    {
        Vida = vida;
        Nivel = nivel;
    }
    public string NumVida_Daño()
    {

        return $"Vida del enemigo {Vida}. Nivel : {Nivel}";
    }

     public void MoverseEjeX(int unidades)
    {
        
        Console.WriteLine($"El enemigo se movió {unidades} unidades en el eje X.");
    }

     public void MoverseEjeY(int unidades)
    {
        
        Console.WriteLine($"El enemigo se movió {unidades} unidades en el eje Y.");
    }
}
