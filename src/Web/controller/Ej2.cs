using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Ej2;

namespace Web.controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2 : ControllerBase
    {
        [HttpPost("create-standard-photos")]
        public ActionResult GetStandardPhotos(int? pages){

            PhotoBook photoBook = pages==null? new PhotoBook():new PhotoBook(pages);
            
            return Ok(photoBook.GetNumberPages());
        }

        [HttpPost("create-big-photos")]
        public ActionResult GetBigPhoto(){

            BigPhotoBook BigPhotoBook=new BigPhotoBook();
            return Ok(BigPhotoBook.GetNumberPages());
        }

        [HttpGet("select-photos")]
        public ActionResult SelectPhotos(int id){
            return Ok(PhotoBook.GetDataPhotoBooks().Where(x=>x.selfId==id).Select(x=>x.GetNumberPages()).ToList()[0]);
        }

        [HttpGet("aux")]
        public ActionResult aux(){
            return Ok(PhotoBook.GetDataPhotoBooks());
        }
        /*,BigPhotoBook bigPhotoBook,int numPages*/


    }
}
