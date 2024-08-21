using Microsoft.AspNetCore.Mvc;
using Web.Ej2;
using System.Collections.Generic;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej2Controller : ControllerBase
    {
        private static List<PhotoBook> ListPhotoBook = new List<PhotoBook>();
        private static List<BigPhotoBook> ListBigPhotoBook = new List<BigPhotoBook>();

        [HttpPost("[action]")]
        public ActionResult<PhotoBook> CreatePhotoBook([FromBody] int numPages = 16)
        {
            var photoBook = new PhotoBook(numPages);
            ListPhotoBook.Add(photoBook);
            return CreatedAtAction(nameof(GetPhotoBookById), new { bookId = photoBook.Id }, photoBook);
        }

        [HttpPost("[action]")]
        public ActionResult<BigPhotoBook> CreateBigPhotoBook([FromBody] int numPages = 64)
        {
            var bigPhotoBook = new BigPhotoBook(numPages);
            ListBigPhotoBook.Add(bigPhotoBook);
            return CreatedAtAction(nameof(GetBigPhotoBookById), new { bookId = bigPhotoBook.Id }, bigPhotoBook);
        }

        [HttpGet("[action]")]
        public ActionResult<PhotoBook> GetPhotoBookById([FromQuery] int bookId)
        {
            var book = ListPhotoBook.FirstOrDefault(b => b.Id == bookId);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpGet("[action]")]
        public ActionResult<BigPhotoBook> GetBigPhotoBookById([FromQuery] int bookId)
        {
            var book = ListBigPhotoBook.FirstOrDefault(b => b.Id == bookId);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpGet("[action]")]
        public ActionResult<List<PhotoBook>> GetAllPhotoBooks()
        {
            return Ok(ListPhotoBook);
        }

        [HttpGet("[action]")]
        public ActionResult<List<BigPhotoBook>> GetAllBigPhotoBooks()
        {
            return Ok(ListBigPhotoBook);
        }
    }
}
