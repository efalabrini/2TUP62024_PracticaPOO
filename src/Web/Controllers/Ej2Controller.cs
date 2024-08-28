using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

using Web.Ej2;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej2Controller : ControllerBase
{
    private static List<PhotoBook> albums = [];
    [HttpPost("AlbunStanda")]
    public ActionResult CrearAlbunStandar(int? numPages)
    {
        PhotoBook newPhotoBook;
        if (numPages > 0)
        {
            newPhotoBook = new PhotoBook(numPages.Value);
        }
        else if (numPages <= 0)
        {
            return BadRequest("Error al ingresar la cantidad de paginas, no puede ser negativo o cero.");
        }
        else
        {
            newPhotoBook = new PhotoBook();
        }
        int page = newPhotoBook.GetNumberPages();
        albums.Add(newPhotoBook);
        return Ok($"el libro de fotos tiene {page} paginas Id:{newPhotoBook.Id} ");
    }

    [HttpPost("AlbunGrande")]
    public ActionResult CrearAlbunGrande()
    {
        BigPhotoBook newBigPhotoBook;
        newBigPhotoBook = new BigPhotoBook();
        int page = newBigPhotoBook.GetNumberPages();
        albums.Add(newBigPhotoBook);
        return Ok($"el libro grande de fotos tiene {page} paginas");
    }
    [HttpGet("GetById/Albunes")]
    public ActionResult GetAlbumes(int id)
    {
        PhotoBook? book = albums.Find(x => x.Id == id);
        if (book != null)
        {
            return Ok($"Id: {book.Id} - Paginas:{book.GetNumberPages()} paginas");
        }
        return NotFound("No se encontró el album");
    }
    [HttpGet("GetAll")]
    public ActionResult GetAllAlbumes()
    {
        var result = albums.Select((album, index) => new { album.Id, Pages = album.GetNumberPages() }).ToList();
        return Ok(result);
    }

}