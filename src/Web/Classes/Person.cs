using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Classes
{
    public class Person
    {
        //establezco las props
        protected string _name { get; set; }
        protected int _age { get; set; }

      
        //constructor
        public Person(string name)
        {
            _name = name;
        }

        //metodos
        public void SetAge(int age)
        {
            if (age >= 0)
            {
                this._age = age;
            }
        }

        public string Name => _name;

        public int Age => this._age >= 0 ? this._age : -1;

        public virtual string SayHi()
        {
            return "is saying: Hi!!";
        }
    }
}
