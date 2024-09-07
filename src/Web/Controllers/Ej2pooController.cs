using Microsoft.AspNetCore.Mvc;
using Web.Ej2poo;

namespace Web.Controllers;

[ApiController]
[Route("[controller]/[Action]")]
public class Ej2pooController : ControllerBase
{
    static List<PhotoBook> photoBooks = new List<PhotoBook>();
    [HttpPost]
    public IActionResult AlbumEstandar(int pages=16)
    {   
        photoBooks.Add(new PhotoBook(pages));
        return Ok($"Se creo un album estandar de {pages} paginas");
    }
    [HttpPost]
    public IActionResult AlbumGrande()
    {   
        photoBooks.Add(new BigPhotoBook());
        return Ok("Se creo un album grande con 64 paginas");
    }
    [HttpGet]
    //Esto podria mejorar (no trabajar con index?)
    public IActionResult NumPaginas(int id)
    {
        if (id > 0 && id <= photoBooks.Count )
        {
            return Ok(photoBooks[id-1].GetNumPages());
        }
        else{
            return BadRequest("Ingreso de ID incorrecto");
        }
    }
    [HttpGet]
    public IActionResult TodosLosAlbumes()
    {
        return Ok(photoBooks);
    }
}
