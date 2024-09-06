using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Ej2;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2Controller : ControllerBase
    {

        static List<PhotoBook> listAlbums = new List<PhotoBook>();


        [HttpPost("PhotoBook")]
        public IActionResult PhotoBook ( int? numPages = null)
        {

            PhotoBook photoBook = numPages.HasValue ? new PhotoBook(numPages.Value) : new PhotoBook();

            listAlbums.Add(photoBook);

            return Ok(photoBook.GetNumberPages());
        }


        [HttpPost("BigPhotoBook")]
        public IActionResult BigPhotoBook()
        {
            BigPhotoBook bigPhotoBook = new BigPhotoBook();
            listAlbums.Add(bigPhotoBook);

            return Ok(bigPhotoBook.GetNumberPages());
        }

        [HttpGet("PhotoBookLength")]
        public IActionResult PhotoBookLength(int id)
        {
            var photoBook = listAlbums.FirstOrDefault(i => i.id == id);

            if (photoBook != null)
            {
                return Ok(photoBook.GetNumberPages());
            }

            return StatusCode(404);

        }


        [HttpGet("GetAll")]
        public IActionResult GetAll() 
        {
            var result = new List<object>();

            foreach (var book in listAlbums)
            {
                result.Add(new
                {
                    BookId = book.id,
                    PageCount = book.GetNumberPages()
                });
            }


            return Ok(result); 
        }
    }
}
