using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.NetworkInformation;
using System;

namespace Web.Ej5
{
    public class PersonajeDeMagia : Personaje, IMoverse
    {
        public PersonajeDeMagia(string nombre, int agilidad, int fuerza)
        {
            Nombre = nombre;
            Agilidad = agilidad;
            Magia = 60;
            Fuerza = fuerza;
        }
        public PersonajeDeMagia(string nombre, int agilidad, int magia, int fuerza)
        {
            Nombre = nombre;
            Agilidad = agilidad;
            Magia = magia;
            Fuerza = fuerza;
         
        }
        public override int CalcularDanio()
        {
            return Fuerza + Agilidad + Magia * 4;
        }

        public override string Atacar()
        {
            int danio = CalcularDanio();
            return $"{Nombre} hizo {danio} de daño gracias a su magia";
        }
    }
}