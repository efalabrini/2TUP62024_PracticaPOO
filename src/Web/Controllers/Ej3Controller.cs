using Microsoft.AspNetCore.Mvc;
using Web.Ej3;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class Ej3Controller : ControllerBase
{
    [HttpPost("CreatePerson")]
    public ActionResult Person(string name)
    {
        if(!string.IsNullOrEmpty(name))
        {
            var person = new Persona(name);
            return Ok(person.Saludar());
        }
        else
        {
            return BadRequest();
        }
    }

    [HttpPost("CreateStudent")]
    public ActionResult Student(string name, int age)
    {
        if(!string.IsNullOrEmpty(name) && age > 0)
        {
            var student = new Estudiante(name);

            student.SetEdad(age);

            var studentData = new
            {
                saludo = student.Saludar(),
                edad = student.MostrarEdad(),
                estudiante = student.Estudiar()
            };

            return Ok(studentData);

        }

        else
        {
            return BadRequest();
        }
    }

    [HttpPost("CreateTeacher")]
    public ActionResult Teacher(string name)
    {
        if(!string.IsNullOrEmpty(name))
        {
            var teacher = new Profesor(name);

            var teacherData = new
            {
                saludo = teacher.Saludar(),
                explicacion = teacher.Explicar()
            };

            return Ok(teacherData);
        }
        else
        {
            return BadRequest();
        }


    }
}