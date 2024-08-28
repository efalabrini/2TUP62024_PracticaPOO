using System;

namespace Web.Ej2;

public class PhotoBook
{
        protected int numPages;

        //por defecto que inicializa el álbum con 16 páginas
        public PhotoBook()
        {
            numPages = 16;
        }

        //si se quiere especificar el número de páginas
        public PhotoBook(int numPages)
        {
            this.numPages = numPages;
        }

        //obtener el número de páginas
        public int GetNumberPages()
        {
            return numPages;
        }
    }

    public class BigPhotoBook : PhotoBook
    {
        //inicializa el álbum con 64 páginas
        public BigPhotoBook()
        {
            numPages = 64;
        }
    }

