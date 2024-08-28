using Microsoft.AspNetCore.Mvc;
using Web.Ej2;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej2Controller : Controller
    {
        private static List<Photobook> albums = new List<Photobook>();


        [HttpPost("standard")]
        public IActionResult CreateStandardPhotoBook([FromQuery] int? pages)
        {
            Photobook album;

            if (pages.HasValue)
            {
                album = new Photobook(pages.Value);
            }
            else
            {
                album = new Photobook();
                pages = album.GetNumberPages();
            }

            albums.Add(album);
            return Ok("El album creado tiene " + pages + " paginas");
        }

        
        [HttpPost("largePhotoBook")]
        public IActionResult CreateLargePhotoBook()
        {
            var album = new BigPhotoBook();
            albums.Add(album);
            return Ok();
        }

        [HttpGet("pages /{id}")]
        public IActionResult GetNumberOfPages(int id)
        {
            var album = albums.ElementAtOrDefault(id - 1);
            if(album == null)
            {
                return NotFound("Album no encontrado");
            }

            return Ok("El album encontrado tiene " + album.GetNumberPages() + " páginas.");
        }

        [HttpGet("getAll")]
        public IActionResult GetAllAlbums()
        {
            var result = albums.Select((album, index) => new { Id = index + 1, Pages = album.GetNumberPages() }).ToList();
            return Ok(result);
        }
    }
}
