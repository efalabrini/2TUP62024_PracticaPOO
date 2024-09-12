namespace Web.Ejr2
{
    public class PhotoBook
    {
        protected int numPages { get; set; }
  


        public PhotoBook() 
        {
            numPages = 16;
          
        }

        public PhotoBook(int numPages)
        {
            this.numPages = numPages;
           
        }

        public string GetNumberPages()
        {
            return ($"el libro tiene {numPages} paginas");
        }

    }
}



//Ej2
//Creación de Clases:

//Implementar una clase PhotoBook con un atributo protected llamado numPages de tipo int.
//Esta clase debe tener un método público GetNumberPages que retorne el número de páginas del álbum.
//El constructor por defecto debe inicializar el álbum con 16 páginas.
//Incluir un constructor que permita especificar el número de páginas del álbum.
//Crear una clase derivada BigPhotoBook cuyo constructor inicialice el álbum con 64 páginas.
