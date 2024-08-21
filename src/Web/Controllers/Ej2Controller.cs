using Microsoft.AspNetCore.Http;
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
            return Ok($"se creo album estandar con {pages} paginas");
        }

        [HttpPost("[action]")]
        public ActionResult<string> AlbumGrande()
        {
            photoBooks.Add(new BigPhotoBook());
            return Ok("se creo album grande de 64 paginas");
        }

        [HttpGet("[action]/{id}")]
        public ActionResult<int> GetNumeroDePaginas(int id)
        {
            PhotoBook album = photoBooks.Find(p => p.id == id);

            if (album != null)
            {
                return Ok(album.GetNumeroDePaginas());
            }
            else
            {
                return NotFound($"no se econtro album con el siguiente {id}");
            }
        }
        [HttpGet("[action]")]
        public ActionResult<List<PhotoBook>> getAllBooks()
        {
            return photoBooks;
        }
    }
}
