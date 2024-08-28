using System.Net.Http.Headers;
using System.Runtime.Intrinsics.X86;
using Microsoft.AspNetCore.Mvc;

using Web.ej2;


namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej2Controllers : ControllerBase
{
    static List<PhotoBook> listPhoto = new List<PhotoBook>();
    


    [HttpPost("PhotoBook")]
    public ActionResult PhotoBook(int? pages = null)
    {

        PhotoBook photo = pages.HasValue ? new PhotoBook(pages.Value) : new PhotoBook();

        listPhoto.Add(photo);

        return Ok(photo.GetNumberPages());
    }

    [HttpPost("BigPhotoBook")]

    public ActionResult BigPhotoBook()
    {
        BigPhotoBook bigPhoto = new BigPhotoBook();
        listPhoto.Add(bigPhoto);

        return Ok(bigPhoto.GetNumberPages());
    }

    [HttpGet("ConsultaId")]

    public ActionResult ConsultaId(int id){

        var album = listPhoto.FirstOrDefault(i => i.id == id);

        if(album != null){
            return Ok(album.GetNumberPages());
        }

        // foreach (PhotoBook album in listPhoto)
        // {
        //     if (album.id == id){
        //         return Ok(album.GetNumberPages());
        //     }
        // }

        return StatusCode(404);
    }

    [HttpGet("RetornarTodo")]

    public ActionResult<List<PhotoBook>> RetornaTodo(){
        
        List<object> listObj = new List<object>(); 

         foreach (PhotoBook album in listPhoto)
            {
                listObj.Add(new
                {
                    Id = album.id,
                    NumeroPagina = album.GetNumberPages()
                });
            }

        return Ok(listObj);

    }
}