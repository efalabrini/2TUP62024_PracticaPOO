using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Web.ej2;
namespace Web.Controllers;

[ApiController]
[Route("[controller]")]


public class Ej2Controller : ControllerBase
{
    public static List<PhotoBook> listBooks = new List<PhotoBook>();
    [HttpPost("[action]")]
    public int PhotoBook(int? pages = null)
    {
        var album = pages.HasValue ? new PhotoBook(pages.Value) : new PhotoBook();
        listBooks.Add(album);
        return album.GetNumberPages();
    }

    [HttpPost("[action]")]
    public int BigPhotoBook()
    {
        var bigAlbum = new BigPhotoBook();
        listBooks.Add(bigAlbum);
        return bigAlbum.GetNumberPages();
    }

    [HttpGet("[action]")]
    public ActionResult GetCertainBook(int id)
    {
        foreach (PhotoBook album in listBooks)
        {
            if (album.id == id)
            {
                return Ok(album.GetNumberPages());
            }
        }
        return StatusCode(400, "Id no existente");
    }

    [HttpGet("[action]")]
    public List<Object> GetAll()
    {
        return listBooks.Select(album =>
        {
            return new
            {
                id = album.id,
                pages = album.GetNumberPages()
            };
        }).ToList<Object>();
    }
}