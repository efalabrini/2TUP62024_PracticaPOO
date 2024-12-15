using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

using Web.ej3;


[ApiController]
[Route("[controller]")]


public class Ej3Controller : ControllerBase
{
    [HttpPost("[action]")]

    public String newPersona(String nombre)
    {
        Persona persona1 = new Persona(nombre);
        return persona1.Saludar();
    }

    [HttpPost("[action]")]

    public String newStudent(String nombre, int edad)
    {
        Estudiante estudiante1 = new Estudiante(nombre);
        estudiante1.SetEdad(edad);
        return $"{estudiante1.Saludar()}.{estudiante1.MostrarEdad()}";
    }


    [HttpPost("[action]")]

    public String newTeacher(String nombre)
    {
        Profesor profesor1 = new Profesor(nombre);

        return $"{profesor1.Saludar()}.{profesor1.Explicar()}";
    }

}