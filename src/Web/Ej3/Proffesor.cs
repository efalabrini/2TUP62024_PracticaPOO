namespace Web.Ej3
{

    public class Proffesor: Person{

        public string name{get;set;}
        public Proffesor(string Name){
            name=Name;
        }
        public string Explain(){
            return "Estoy explicando. ";
        }
        public new string SayHi(){
            return $"Hola soy el profesor {name}. ";
        }
    }


}