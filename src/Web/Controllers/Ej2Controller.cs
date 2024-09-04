using Microsoft.AspNetCore.Mvc;
using Web.Ej2;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]

public class Ej2Controller : ControllerBase
{
    static List<PhotoBook> listBooks = new List<PhotoBook>();

    [HttpPost("PhotoBook")]
    public ActionResult PhotoBook(int? pages = null)
    {
        PhotoBook photoBook = pages.HasValue ? new PhotoBook(pages.Value) : new PhotoBook();
        listBooks.Add(photoBook);

        return Ok(photoBook.GetNumberPages());
    }

    [HttpPost("BigPhotoBook")]
    public ActionResult BigPhotoBook()
    {
        BigPhotoBook bigPhotoBook = new BigPhotoBook();
        listBooks.Add(bigPhotoBook);

        return Ok(bigPhotoBook.GetNumberPages());
    }

    [HttpGet("AskId")]
    public ActionResult AskId(int id)
    {
        var album = listBooks.FirstOrDefault(i => i.id == id);

        if(album != null)
        {
            return Ok(album.GetNumberPages());
        }

        return StatusCode(404);
    }

    [HttpGet("GetAllBook")]
    public ActionResult GetAllBook()
    {
        var result = listBooks.Select(book => new
        {
            BookId = book.id,
            PageCount = book.GetNumberPages()
        }).ToList();

        return Ok(result);
    }



}