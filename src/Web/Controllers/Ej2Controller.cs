using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.Win32;
using System.Diagnostics;
using System;
using Web.Ej2;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2Controller : ControllerBase
    {
        [HttpPost("CreateStandardAlbum")]
        public IActionResult Create([FromQuery] int pages)
        {
            if (pages < 0  )
            {
                return BadRequest();
            }

            if (pages == 0)

            {
                var newStandardPhotobook = new PhotoBook();
                Albums.Add(newStandardPhotobook);
                return Ok(newStandardPhotobook.GetFormattedDetails());
            }
            else
            {
                var newStandardPhotobook = new PhotoBook(pages);
                Albums.Add(newStandardPhotobook);
                return Ok(newStandardPhotobook.GetFormattedDetails());
            }
        }

        [HttpPost("CreateBigAlbum")]
        public IActionResult CreateBigPhotoBook()
        {
            var newBigPhotobook = new BigPhotoBook();
            Albums.Add(newBigPhotobook);
            return Ok(newBigPhotobook.GetFormattedDetails());
        }

        [HttpGet("GetById/{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var photobook = Albums.FirstOrDefault(book => book.Id == id);

            if (photobook == null)
            {
                return NotFound($"Photobook with ID {id} not found.");
            }

            return Ok($"{photobook.GetNumberPages()} pages");
        }


        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var response = Albums.Select(album => album.GetFormattedDetails()).ToList();
            if (response == null || response.Count == 0)
            {
                return NotFound($"No books were found!");
            }
            return Ok(response);
        }

        private static List<PhotoBook> Albums = new List<PhotoBook>();
    }
}

