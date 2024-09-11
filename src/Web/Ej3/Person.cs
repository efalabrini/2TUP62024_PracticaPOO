namespace Web.Ej3
{

    public class Person{
        public int age;
        public string? name{get;set;}
        public Person(string Name){
            name=Name;
        }
        public void SetAge(int Age){
            age = Age;
        }
        public string SayHi(){
            return $"Hola soy {name}. ";
        }
    }
    
}