using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;
[ApiController]
[Route("[controller]")]

    public class Eje2Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }

