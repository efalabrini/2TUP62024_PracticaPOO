using Microsoft.AspNetCore.Mvc;
using Web.Ej2;


namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Ej2Controller : ControllerBase
    {
        static List<PhotoBook> listBooks = new List<PhotoBook>();

        [HttpGet("GetAllBook")]
        public ActionResult GetAllBook()
        {

            if (listBooks.Count == 0)
            {
                return NotFound();
            }

            var result = listBooks.Select(book => new
            {
                BookId = book.id,
                PageCount = book.GetNumberPages(),
            }).ToList();

            return Ok(result);
        }

        [HttpGet("GetById")]
        public IActionResult Get(int id)
        {
            var book = listBooks.Find(f => f.id == id);
            if (book == null)
            {
                return NotFound();
            }

            return Ok($"El album {id} tiene {book.GetNumberPages()} paginas.");
        }

        [HttpPost("AddStandardBook")]
        public IActionResult AddStandardBook(int pages)
        {
            PhotoBook book = new PhotoBook(pages);
            listBooks.Add(book);
            return Ok(book);
        }

        [HttpPost("AddBigBook")]
        public IActionResult AddBigBook()
        {
            var bigbook = new BigPhotoBook();
            listBooks.Add(bigbook);
            return Ok(bigbook);
        }
    }
}