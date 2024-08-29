namespace Web.ej3{
    public class Persona{
        public int edad {get; set;}
        public string nombre {get; set;}

        public Persona(string name){
            edad = 0;
            nombre = name;
        }

        public virtual string Saludar(){
            return "Hola";
        }

        public int SetEdad(int edadIngresada){
            return edad = edadIngresada;
        }
    }
}