using Microsoft.AspNetCore.Mvc;
using Web.Ej2;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class Ej2Controller : ControllerBase
    {
        static List<PhotoBook> album = new List<PhotoBook>();

        [HttpPost("AlbumEstandar")]
        public IActionResult AlbumEstandar(int pages = 16)
        {
            album.Add(new PhotoBook(pages));
            return Ok($"Se creo el album con {pages} paginas");
        }

        [HttpPost("AlbumGrande")]
        public IActionResult AlbumGrande()
        {
            album.Add(new BigPhotoBook());
            return Ok("Se creo un album con 64 paginas");
        }


        [HttpGet("IdenticarPage/{id}")]
        public IActionResult IdentificarPage(int id) 
        {
           var albumEncontrado = album.FirstOrDefault(a => a.Id == id);
            if (albumEncontrado == null)
            {
                return NotFound($"Albun con ID {id} no encontrado");
            }

            return Ok(albumEncontrado);

        }


        [HttpGet("RetornarAlbum")]
        public IActionResult RetornarAlbum()
        {
            return Ok(album);
        }


    }
}
