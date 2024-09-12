using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Ej1;
using Web.Ej3;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3Controller : ControllerBase
    {
        [HttpPost("CreatePerson")]
        public ActionResult Person(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                var person = new Person(name);
                return Ok(person.sayHi());
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost("CreateStudent")]
        public ActionResult Student(string name, int age)
        {
            if (!string.IsNullOrEmpty(name) && age > 0)
            {
                var student = new Student(name);

                student.setAge(age);

                var studentData = new
                {
                    saludo = student.sayHi(),
                    edad = student.showAge(),
                    estudiante = student.Studying()
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
            if (!string.IsNullOrEmpty(name))
            {
                var teacher = new Profesor(name);

                var teacherData = new
                {
                    saludo = teacher.sayHi(),
                    explicacion = teacher.Explain()
                };

                return Ok(teacherData);
            }
            else
            {
                return BadRequest();
            }


        }
    }
}
