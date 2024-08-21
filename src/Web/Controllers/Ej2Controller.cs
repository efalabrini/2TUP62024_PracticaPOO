using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Web.Ej2;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej2Controller : ControllerBase
{

    private static readonly List<PhotoBook> photoBooks = [];

    [HttpPost("CreateStandardAlbum")]
    public IActionResult CreateStandardAlbum([FromBody] int? paginas)
    {
        PhotoBook album = paginas.HasValue ? new PhotoBook(paginas.Value) : new PhotoBook();
    
        photoBooks.Add(album);

        return Ok("Album creado. Páginas: " + album.GetNumberPages() + " Id: " + album.Id);
    }

    [HttpPost("CreateBigAlbum")]
    public IActionResult CreateBigAlbum()
    {
        BigPhotoBook album = new BigPhotoBook();

        photoBooks.Add(album);
        
        return Ok("Album creado. Páginas: " + album.GetNumberPages() + " Id: " + album.Id);
    }

    [HttpGet("CheckAlbum/{id}")]
    public IActionResult CheckAlbum(int id)
    {
        PhotoBook book = photoBooks.Find(x => x.Id == id);

        if (book != null)
        {
            return Ok($"Encontrado: {book.GetNumberPages()} páginas - ID: {book.Id}");
        } else {
            return BadRequest(400);
        }
    }

    [HttpGet("GetAll")]
    public IActionResult GetAll()
    {
        var books = photoBooks.Select(album => new
        {
            Id = album.Id,
            NumPages = album.GetNumberPages()
        }).ToList();

        return Ok(books);
    }
}
