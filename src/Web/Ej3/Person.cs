namespace Web.Ej3
{
    public class Person
    {
        public string name;
        public int age;
        public Person(string Name)
        {

            name = Name;

        }

        public void setAge(int Age)
        {
            age = Age;
        }

        public virtual string sayHi()
        {
            return $"Hola {name}";
        }
    }
}
