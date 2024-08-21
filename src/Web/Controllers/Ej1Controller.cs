using Microsoft.AspNetCore.Mvc;

using Web.Ej1;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class Ej1Controller : ControllerBase {
    [HttpGet]
    public List<string> Get(string name1, string name2, string name3) {
        var persona1 = new Persona(name1);
        var persona2 = new Persona(name2);
        var persona3 = new Persona(name3);
        var personas = new List<string> {persona1.Saludar(), persona2.Saludar(),persona3.Saludar()};
        return personas;
        
    }
}