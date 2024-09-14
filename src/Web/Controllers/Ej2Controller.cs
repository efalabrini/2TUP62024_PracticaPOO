using Microsoft.AspNetCore.Mvc;
using Web.Ej2;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class Ej2Controller : Controller
{
    private static List<PhotoBook> albums = new List<PhotoBook>();

    [HttpPost("createStandarAlbum")]
    public IActionResult CreateStandarAlbum(int? numPages)
    {
        PhotoBook album;
        if (numPages.HasValue)
        {
            album = new PhotoBook(numPages.Value);
        }
        else
        {
            album = new PhotoBook();
        }
        albums.Add(album);
        return Ok("Album estándar creado con éxito");
    }

    [HttpPost("createBigAlbum")]
    public IActionResult CreateBigAlbum()
    {
        var album = new BigPhotoBook();
        albums.Add(album);
        return Ok("Album grande creado con éxito");
    }

    [HttpGet("checkNumberPages")]
    public IActionResult CheckNumberPages(int id)
    {
        int i;
        if (albums.Count == 0) { 
            return NotFound("No hay álbumes existentes"); 
        } else if (id <= 0) { 
            return BadRequest("Id inválida"); 
        }

        for (i = 0; i < albums.Count; i++)
        {
            if (albums[i].Id == id) { break; }
        }

        if (i == albums.Count) { 
            return NotFound($"No se ha encontrado el album con la id: {id}"); 
        }

        return Ok(albums[i].GetNumberPages());
    }

    [HttpGet("returnAlbums")]
    public IActionResult ReturnAlbums()
    {
        return Ok(albums);
    }
}
