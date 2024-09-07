using Microsoft.AspNetCore.Mvc;
using Web.Ej3;

namespace Web.Controllers;

[ApiController]
[Route("[controller]/[Action]")]
public class Ej3Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Person(string name)
    {
        Person person = new Person(name);
        return Ok(person.SayHi());
    }
    [HttpGet]
    public IActionResult Student(string name,int age)
    {
        Student student = new Student(name);
        student.SetAge(age);
        return Ok(student.SayHi()+ $"Tengo {student.age}.");
    }
    [HttpGet]
    public IActionResult Professor(string name,int age)
    {
        Professor professor = new Professor(name);
        professor.SetAge(age);
        return Ok(professor.SayHi()+professor.Explain());
    }
}