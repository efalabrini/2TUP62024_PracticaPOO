using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Web.Ej2;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej2Controller : ControllerBase
    {
        private static List<PhotoBook> photoBooks = new List<PhotoBook>();
        private static List<BigPhotoBook> bigPhotoBooks = new List<BigPhotoBook>();


        [HttpPost("CreatePhotoBook")]
        public ActionResult<PhotoBook> CreatePhotoBook([FromQuery] int? numPages)
        {
            PhotoBook photoBook;

            if (numPages.HasValue)
            {
                photoBook = new PhotoBook(numPages.Value);
            }
            else
            {
                photoBook = new PhotoBook();
            }

            photoBooks.Add(photoBook);
            return Ok(photoBook);
        }

        [HttpPost("CreateBigPhotoBook")]
        public ActionResult<BigPhotoBook> CreateBigPhotoBook()
        {
            var bigPhotoBook = new BigPhotoBook();
            bigPhotoBooks.Add(bigPhotoBook);
            return Ok(bigPhotoBook);
        }

        [HttpGet("GetById")]
        public IActionResult GetById([FromQuery] int id)
        {

            var photoBook = photoBooks.FirstOrDefault(pb => pb.Id == id);
            var bigPhotoBook = bigPhotoBooks.FirstOrDefault(bpb => bpb.Id == id);

            if (photoBook != null)
            {
                return Ok(photoBook.GetNumberPages());
            }
            else if (bigPhotoBook != null)
            {
                return Ok(bigPhotoBook.GetNumberPages());
            }
            else
            {
                return NotFound("Álbum no encontrado");
            }
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var allBooks = new
            {
                PhotoBooks = photoBooks,
                BigPhotoBooks = bigPhotoBooks
            };

            return Ok(allBooks);
        }
    }
}
