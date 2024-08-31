using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Ej3;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3 : ControllerBase
    {
        [HttpGet("new-person")]
        public ActionResult newPerson(){
            Persona persona =new Persona();
            
            return Ok(persona.Saludar());
        }

        [HttpGet("new-student")]
        public ActionResult newStudent(string name,int age){
            Estudiante estudiante=new Estudiante(name,age);
            List<dynamic> retorno=[estudiante.Saludar(),estudiante.age];
            return Ok(retorno);
        }

        [HttpGet("new-teacher")]
        public ActionResult newTeacher(string name,int age){
            Profesor profesor=new Profesor(name,age);
            List<string> retorno=[profesor.Saludar(),profesor.Explicar()];
            return Ok(retorno);
        }
    }
}
