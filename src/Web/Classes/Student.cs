namespace Web.Classes
{
    public class Student : Person
    {
        public Student(string name) : base(name)
        {
        }

        public string Study()
        {
            return $"{this._name} is studying ";
        }

        public override string SayHi()
        {
            return $"The student {this._name} {base.SayHi()}";
        }
    }
}
