using Microsoft.AspNetCore.Mvc;
using Web.Ej2;
using System.Collections.Generic;
using System.Linq;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej2Controller : ControllerBase
    {
        // Lista estática para almacenar los álbumes
        private static List<PhotoBook> photoBooks = new List<PhotoBook>();
        private static int currentId = 0;

        
        [HttpPost("crear-standard")]
        public ActionResult<int> CrearStandardPhotoBook([FromQuery] int? numPages)
        {
            PhotoBook newPhotoBook;
            if (numPages.HasValue)
            {
                newPhotoBook = new PhotoBook(numPages.Value);
            }
            else
            {
                newPhotoBook = new PhotoBook();
            }

            photoBooks.Add(newPhotoBook);
            currentId++;
            return Ok(currentId - 1); // Retorna el ID del nuevo álbum
        }

        // Endpoint para crear un álbum grande
        [HttpPost("crear-grande")]
        public ActionResult<int> CrearBigPhotoBook()
        {
            var newBigPhotoBook = new BigPhotoBook();
            photoBooks.Add(newBigPhotoBook);
            currentId++;
            return Ok(currentId - 1); // Retorna el ID del nuevo álbum
        }

        [HttpGet("GetBy/{id}")]
        public ActionResult<int> ConsultarNumeroPaginas(int id)
        {
            if (id >= 0 && id < photoBooks.Count)
            {
                return Ok($"Album N° {id} - Cantidad de páginas: {photoBooks[id].GetNumberPages()}");
            }
            else
            {
                return NotFound("Álbum no encontrado.");
            }
        }

        [HttpGet("GetAll")]
        public ActionResult<List<int>> RetornarTodosLosAlbums()
        {
            return Ok(photoBooks.Select((pb, index) => $"Album N° {index} - Cantidad de páginas: {pb.GetNumberPages()}").ToList());

        }
    }
}
