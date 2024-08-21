using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Ej2;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2Controller : ControllerBase
    {
        public static List<PhotoBook> photoBooks = new List<PhotoBook>();
        public static List<BigPhotoBook> bigPhotosBooks = new List<BigPhotoBook>();

        [HttpPost("[Action]")]
        public ActionResult AddStandardPhotoBook([FromQuery] int? numPages)
        {
            var photoBook = new PhotoBook(numPages ?? 16);
            photoBooks.Add(photoBook);
            return Ok(new { id = photoBook.Id, numPages = photoBook.GetNumberPages() }); 
            
        }

        [HttpPost("[Action]")]
        public ActionResult AddBigPhotoBook()
        {
            var bigPhotoBook = new BigPhotoBook();
            bigPhotosBooks.Add(bigPhotoBook);
            return Ok(new { id = bigPhotoBook.Id, numPages = bigPhotoBook.GetNumberPages() });
        }

        [HttpGet("GetStandardPagesById/{id}")]
        public ActionResult GetStandardPhotoBookNumberPages(int id)
        {
            var photoBook = photoBooks.FirstOrDefault(pb => pb.Id == id);
            if (photoBook != null)
            {
                return Ok(photoBook.GetNumberPages());
             
            }
            else
            {
               return NotFound();
            }


        }

        [HttpGet("GetBigPagesById/{id}")]
        public ActionResult GetBigPhotoBookNumberPages(int id)
        {
            var bigPhotosBook = bigPhotosBooks.FirstOrDefault(pb => pb.Id == id);
            if (bigPhotosBook != null)
            {
                return Ok(bigPhotosBook.GetNumberPages());
            }
            else
            {
                return NotFound();
            }


        }

        [HttpGet("[Action]")]
        public ActionResult GetAllPhotoBooks()
        {
            var allPhotoBooks = new
            {
                PhotosBooks = photoBooks.Select(pb => new
                {
                    id = pb.Id,
                    numPages = pb.GetNumberPages()
                }).ToList(),

                BigPhotoBooks = bigPhotosBooks.Select(bpb => new
                {
                    id = bpb.Id,
                    numPages = bpb.GetNumberPages()
                }).ToList()
            };

            return Ok(allPhotoBooks);
        }

    }
}
