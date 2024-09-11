using System;

namespace Web.Ej5;

public class PersonajeDeAgilidad : Personaje,IMoverse
{
    public PersonajeDeAgilidad(string nombre, int magia, int agilidad,int fuerza) 
    {
        Nombre = nombre;
        Magia = magia;
        Agilidad = agilidad;
        Fuerza = fuerza;
    }

    public override int CalcularDanio()
    {
        int danio = (Fuerza / 2) *Agilidad* (Magia / 2);
        return danio;
    }

    public override string Atacar()
    {
        return $"{Nombre} ataca con agilidad y precisión!";
    }

    public override string DescripcionBatalla()
    {
        return $"{Nombre} usa su agilidad para esquivar y atacar con rapidez!";
    }

      public void MoverseEjeX(int unidades)
    {
        
        Console.WriteLine($"{Nombre} se movió {unidades} unidades en el eje X.");
    }

     public void MoverseEjeY(int unidades)
    {
        
        Console.WriteLine($"{Nombre} se movió {unidades} unidades en el eje Y.");
    } 
}
