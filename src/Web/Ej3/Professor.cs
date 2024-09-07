namespace Web.Ej3
{

    public class Professor: Person{

        public Professor(string Name) : base(Name){
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