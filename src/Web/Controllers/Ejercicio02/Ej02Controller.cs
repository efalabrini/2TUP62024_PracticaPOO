using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Web.Controllers.Ejercicio02;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumesController : ControllerBase
    {

        private static List<PhotoBook> albumes = new List<PhotoBook>();



        [HttpPost("crear-estandar")]
        public ActionResult CrearAlbumEstandar([FromBody] int? numPages = null)
        {
            PhotoBook album;


            if (numPages.HasValue)
            {
                album = new PhotoBook(numPages.Value);
            }
            else
            {

                album = new PhotoBook();
            }

            albumes.Add(album);
            int nuevoId = albumes.Count;

            return Ok($"Álbum estándar creado con {album.GetNumberPages()} páginas. ID del álbum: {nuevoId}");
        }


        [HttpPost("crear-grande")]
        public ActionResult CrearAlbumGrande()
        {
            BigPhotoBook album = new BigPhotoBook();
            albumes.Add(album);
            int nuevoId = albumes.Count;
            return Ok($"Álbum grande creado con {album.GetNumberPages()} páginas. ID del álbum: {nuevoId}");
        }


        [HttpGet("consultar/{id}")]
        public ActionResult ConsultarNumeroDePaginas(int id)
        {
            if (id < 1 || id > albumes.Count)
            {
                return NotFound("Álbum no encontrado.");
            }

            var album = albumes[id - 1];
            return Ok($"El álbum con ID {id} tiene {album.GetNumberPages()} páginas.");
        }

        [HttpGet("todos")]
        public ActionResult ObtenerTodosLosAlbumes()
        {
            if (!albumes.Any())
            {
                return NotFound("No hay álbumes disponibles.");
            }

            var listaAlbumes = albumes.Select((album, index) => new
            {
                Id = index + 1,
                NumeroDePaginas = album.GetNumberPages()
            });

            return Ok(listaAlbumes);
        }
    }
}
