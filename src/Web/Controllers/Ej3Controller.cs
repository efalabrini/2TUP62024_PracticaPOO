using Microsoft.AspNetCore.Mvc;
using Web.Ej3;

namespace Web.Controllers;
//se ingresan los nombres al crear el student y el proffesor
//ya que el enunciado no especifica cuando asignarlos
[ApiController]
[Route("[controller]/[Action]")]
public class Ej3Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Person()
    {
        Person person = new Person();
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
    public IActionResult Proffesor(string name,int age)
    {
        Proffesor proffesor = new Proffesor(name);
        proffesor.SetAge(age);
        return Ok(proffesor.SayHi()+proffesor.Explain());
    }
}