using Microsoft.AspNetCore.Mvc;
using Web.Ej2;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2Controller : ControllerBase
    {
        static List<PhotoBook> photoBooks = new List<PhotoBook>();

        [HttpPost("[action]")]
        public ActionResult<string> AlbumEstandar([FromBody] int pages = 16)
        {
            photoBooks.Add(new PhotoBook(pages));
            return Ok($"Se creo un albun con {pages} paginas (estandar)");
        }

        [HttpPost("[action]")]
        public ActionResult<string> AlbumGrande()
        {
            photoBooks.Add(new BigPhotoBook());
            return Ok("Se creo un album grande");
        }

        [HttpGet("[action] / {id}")]
        public ActionResult<int> GetNumberPages(int id) 
        {
            PhotoBook album = photoBooks.Find(p => p.id == id);

            if (album != null)
            {
                return Ok(album.GetNumberPages());  
            }
            else 
            {
                return NotFound($"no album con la id: {id}");
            }
        }

        [HttpGet("[action]")]
        public ActionResult<List<PhotoBook>> GetAllPhotos() 
        {
            return photoBooks;
        }


    }
}
