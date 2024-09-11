using System;
using Microsoft.AspNetCore.Mvc;
using Web.ej2;

namespace Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class Ej2Controller : ControllerBase
{
    private static List<PhotoBook> albums = new List<PhotoBook>();

        //crear albun estandar
        [HttpPost("crearAlbumEstandar")]
        public IActionResult CrearAlbumEstandar(int? numPages)
        {
            PhotoBook album; //esto lo que hace es que en album solo se almacene un objeto de la clase PhotoBook o una clase derivada

            if (numPages.HasValue)
            {
                album = new PhotoBook(numPages.Value);  
            }
            else
            {
                album = new PhotoBook();  
            }

            albums.Add(album);  
            return Ok("Álbum estándar creado.");
        }

        //crear albun grande
        [HttpPost("crearAlbumGrande")]
        public IActionResult CrearAlbumGrande()
        {
            var album = new BigPhotoBook();  
            albums.Add(album);  
            return Ok("Álbum grande creado.");
        }

        //retonar paginas
        [HttpGet("consultarNumeroPaginas")]
        public IActionResult ConsultarNumeroPaginas()
        {
            if (albums.Count == 0)
            {
                return NotFound("No hay álbumes creados.");
            }

            int numPages = albums[0].GetNumberPages(); 
            return Ok(numPages);
        }

        //Retornar albun
        [HttpGet("retornarTodosLosAlbumes")]
        public IActionResult RetornarTodosLosAlbumes()
        {
            return Ok(albums.Count); 
        }
}
