using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Cryptography.X509Certificates;
using Web.Ej2;

namespace Web.Controllers
{ 
    [ApiController]
    [Route("[controller]")]
    public class CreatePhotoBook : Controller
    {
        //Al ser static, pertenece a todos las instancias de esta clase
        public static List<PhotoBook> photoBooks = new List<PhotoBook>();

        [HttpPost("[action]")]
        public IActionResult StandardPhotoBook(int? numPages = null)
        {
            PhotoBook photoBook = numPages.HasValue ? new PhotoBook(numPages.Value) : new PhotoBook();
            photoBooks.Add(photoBook);
            return Ok(new { Message = $"Álbum estándar creado con {photoBook.GetNumPages()} paginas y su id es {photoBook.GetId()}"});
        }
        
        [HttpPost("[action]")]
        public IActionResult BigPhotoBook()
        {
            BigPhotoBook bigPhotoBook = new BigPhotoBook();
            photoBooks.Add(bigPhotoBook);
            return Ok(new { Message = $"Álbum Grande creado su id es {bigPhotoBook.GetId()}" });
        }

        [HttpGet("[action]")]
        public IActionResult GetPhotoBookById(int id)
        {
            foreach (var photoBook in photoBooks)
            {
                int idPhotoBook = photoBook.GetId();
                if (idPhotoBook == id)
                {
                    return Ok(new {message = $"El libro con el id {id} tiene {photoBook.GetNumPages()} páginas" });
                }
            }
            return NotFound(new {message= $"El Id {id} No fue encontrado"});
            
        }

    }
}



//int?: El signo de interrogación (?) después de int indica que el parámetro numPages es nullable,
//lo que significa que puede aceptar tanto un número entero como un valor null.
//Esto es útil cuando quieres que el parámetro sea opcional 

//numPages = null: Esto significa que el valor predeterminado de numPages será null si no se pasa ningún argumento cuando se 
//llama al método. Así, si el usuario no especifica un número de páginas, se tomará el valor null por defecto,