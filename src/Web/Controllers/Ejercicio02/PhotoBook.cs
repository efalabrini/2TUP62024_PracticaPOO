namespace Web.Controllers.Ejercicio02
{
    public class PhotoBook
    {
        protected int numPages;

        public PhotoBook()
        { 
            numPages = 16;
        }

        public PhotoBook(int pages)
        { 
            numPages = pages;
        }
        public int GetNumberPages()
        {
            return numPages;
        }
    }
}
