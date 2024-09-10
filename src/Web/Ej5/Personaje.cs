using System;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Web.Ej5;

public abstract class Personaje : IMoverse
{
    public string Nombre {get; set;}
    public int Fuerza {get; set;}
    public int Agilidad { get; set;}
    public int Magia {get; set;}

    public abstract int CalcularDanio();


    public virtual string Atacar()
    {
        int x = CalcularDanio();
        return "${nombre} hizo {x} de daño";
    }

    public abstract string DescripcionBatalla();

     public void MoverseEjeX(int unidades)
    {
        
        Console.WriteLine($"{Nombre} se movió {unidades} unidades en el eje X.");
    }

     public void MoverseEjeY(int unidades)
    {
        
        Console.WriteLine($"{Nombre} se movió {unidades} unidades en el eje Y.");
    } 

}
