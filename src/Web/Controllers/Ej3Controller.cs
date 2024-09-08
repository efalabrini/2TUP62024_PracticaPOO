using Microsoft.AspNetCore.Mvc;
using Web.Classes;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej3Controller : Controller
    {
        [HttpPost("[action]")]
        public IActionResult CreatePerson(string name, [FromBody] int age)
        {
            Person person = new Person(name);
            person.SetAge(age);
            return Ok(new { message = $"{person.Name} is {person.Age} years old and {person.SayHi()}" });
        }

        [HttpPost("[action]")]
        public IActionResult CreateStudent(string name, [FromBody] int age)
        {
            Student student = new Student(name);
            student.SetAge(age);
            return Ok(new {message = $"{student.SayHi()} and he is {student.Age} years old. {student.Study()}" });
        }

        [HttpPost("[action]")]
        public IActionResult CreateTeacher(string name, [FromBody] int age)
        {
            Teacher teacher = new Teacher(name);
            teacher.SetAge(age);
            return Ok(new { message = $"{teacher.SayHi()} {teacher.Explain()}" });
        }

    }
}
