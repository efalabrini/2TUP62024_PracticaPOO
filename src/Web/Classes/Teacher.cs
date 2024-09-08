namespace Web.Classes
{
    public class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {
        }

        public string Explain()
        {
            return $"Teacher {this._name} is explaining";
        }

        public override string SayHi()
        {
            return $"Teacher {this._name} is {this.Age} years old and {base.SayHi()}";
        }
    }
}