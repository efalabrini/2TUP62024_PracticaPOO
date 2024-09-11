namespace Web.ej5
{
    public abstract class Personaje : IMoverse{

        protected string nombre {get;set;}
        protected double fuerza {get;set;}
        protected double agilidad {get;set;}
        protected double magia {get;set;}


        public Personaje(string nombreIng, double fuerzaIng, double agilidadIng, double magiaIng){
            nombre  = nombreIng;
            fuerza = fuerzaIng;
            agilidad = agilidadIng;
            magia = magiaIng;
        }

        public abstract double CalcularDanio();


        public virtual string Atacar(){
            return $"{nombre} hizo {fuerza} daño";
        }

        public string MoverseEjeX(int ejeX){
            return $"El jugador {nombre} se movio {ejeX} pasos en el eje X";
        }
        public string MoverseEjeY(int ejeY){
            return $"El jugador {nombre} se movio {ejeY} pasos en el eje Y";
        }
    }
}