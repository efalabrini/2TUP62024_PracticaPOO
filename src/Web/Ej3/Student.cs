namespace Web.Ej3
{

    public class Student : Person{
        
        public Student (string Name): base (Name){
            name = Name;
        }
        public string Studying(){
            return "Estoy estudiando. ";
        }
        public string ShowAge(){
            return $"Mi edad es: {age} años. ";
        }
        public new string SayHi(){
            return $"Hola soy el estudiante {name}. ";
        }
    }

    
}