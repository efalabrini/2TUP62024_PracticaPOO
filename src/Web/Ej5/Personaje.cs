using Microsoft.AspNetCore.Mvc;
using Web.Interfaces;

namespace Web.Ej5
{
    public abstract class Personaje : IMoverse
    {
        public string Nombre { get; set; }
        public float Fuerza { get; set; }
        public float Agilidad { get; set; }
        public float Magia { get; set; }


        public Personaje(string nombre, float fuerza, float agilidad, float magia)
        {
            Nombre = nombre;
            Fuerza = fuerza;
            Agilidad = agilidad;
            Magia = magia;
        }

        public abstract float CalcularDanio();
        public virtual string Atacar()
        {
            return $"{Nombre} hizo {CalcularDanio()} de daño";
        }

        public string MoverseEjeX(int pasos)
        {
            return $"{Nombre} se ha movido {((pasos == 1) ? "1 paso" : $"{pasos} pasos")}) en el eje X";
        }

        public string MoverseEjeY(int pasos)
        {
            return $"{Nombre} enemigo se ha movido un pas en el eje Y";
        }
    }
}
