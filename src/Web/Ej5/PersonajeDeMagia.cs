using System;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Web.Ej5;

public class PersonajeDeMagia : Personaje, IMoverse
{
    public PersonajeDeMagia(string nombre, int magia, int agilidad,int fuerza)
    {
        Nombre = nombre;
        Magia = magia;
        Agilidad = agilidad;
        Fuerza = fuerza;
    }

    public PersonajeDeMagia(string nombre, int agilidad,int fuerza) : this(nombre,60,agilidad,fuerza)
    {

    }

    public int NumMagia(string nombre, int agilidad,int fuerza)
    {
        Nombre = nombre;
        Magia = 60;
        Agilidad = agilidad;
        Fuerza = fuerza;
        return Magia;
    }

     public override int CalcularDanio()
    {
        int danio = Fuerza + Agilidad + (Magia * 4);
        return danio;
    }

    public override string Atacar()
    {
        int x = CalcularDanio();
        return $"{Nombre} hizo {x} de daño gracias a su magia";
    }

    public override string DescripcionBatalla()
    {
        return $"{Nombre} usa su magia para dominar el campo de batalla!";
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
