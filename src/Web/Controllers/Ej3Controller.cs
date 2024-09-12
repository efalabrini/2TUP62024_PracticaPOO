using System.Net.Http.Headers;
using System.Runtime.Intrinsics.X86;
using Microsoft.AspNetCore.Mvc;

using Web.ej3;


namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej2Controllers : ControllerBase
{

    [HttpPost("Persona")]
    public ActionResult Persona(string nombre){
        Persona persona1 = new Persona(nombre);

        return Ok(persona1.Saludar());
    }

    [HttpPost("Estudiantes")]
    public ActionResult Estudiante(string nombre, int edad){
        
        
        Estudiante persona1 = new Estudiante(nombre);
        persona1.SetEdad(edad);

        return Ok($"{persona1.Saludar()} {persona1.MostrarEdad()}");
    }


    [HttpPost("Profesor")]

    public ActionResult Profesor(string nombre, int edad){

        Profesor persona2 = new Profesor(nombre);
        persona2.SetEdad(edad);

        return Ok($"{persona2.Saludar()} y {persona2.Explicar()}");
    }

}