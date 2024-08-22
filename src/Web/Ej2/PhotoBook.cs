namespace Web.Ej2
{
    public class PhotoBook
    {
        private static int _idGenerated = 0;
        public int id { get; set; }
        protected int numPages { get; set; }

        public PhotoBook()
        {
            numPages = 16;
            id = _idGenerated++;
        }

        public PhotoBook(int pages)
        {
            numPages = pages;
            id = _idGenerated++;
        }


        public int GetNumberPages()
        {
            return numPages;
        }
    }
}
