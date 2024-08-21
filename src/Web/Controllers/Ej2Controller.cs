using System;
using Microsoft.AspNetCore.Mvc;
using Web.ej2;

namespace Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class Ej2Controller : ControllerBase
{
    private static List<PhotoBook> albums = new List<PhotoBook>();

        // Crear un álbum estándar con un número opcional de páginas
        [HttpPost("crearAlbumEstandar")]
        public IActionResult CrearAlbumEstandar(int? numPages)
        {
            PhotoBook album;

            if (numPages.HasValue)
            {
                album = new PhotoBook(numPages.Value);  // Crear álbum con el número especificado de páginas
            }
            else
            {
                album = new PhotoBook();  // Crear álbum con 16 páginas por defecto
            }

            albums.Add(album);  // Añadir el álbum a la lista
            return Ok("Álbum estándar creado.");
        }

        // Crear un álbum grande de 64 páginas
        [HttpPost("crearAlbumGrande")]
        public IActionResult CrearAlbumGrande()
        {
            var album = new BigPhotoBook();  // Crear álbum grande
            albums.Add(album);  // Añadir el álbum a la lista
            return Ok("Álbum grande creado.");
        }

        // Consultar el número de páginas del primer álbum
        [HttpGet("consultarNumeroPaginas")]
        public IActionResult ConsultarNumeroPaginas()
        {
            if (albums.Count == 0)
            {
                return NotFound("No hay álbumes creados.");
            }

            int numPages = albums[0].GetNumberPages();  // Obtener el número de páginas del primer álbum
            return Ok(numPages);
        }

        // Retornar el número de álbumes creados
        [HttpGet("retornarTodosLosAlbumes")]
        public IActionResult RetornarTodosLosAlbumes()
        {
            return Ok(albums.Count);  // Retornar la cantidad de álbumes creados
        }
}
