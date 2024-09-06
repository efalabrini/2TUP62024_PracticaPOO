namespace Web.Ej2
{
    public class PhotoBook
    {
        private static int _albumId = 0;
        protected int numPages { get; set; }
        public int id { get; set; }
        public PhotoBook()
        {
            numPages = 16;
            id = _albumId++;
        }

        public PhotoBook(int pages)
        {
            numPages = pages;
            id = _albumId++;
        }
        public int GetNumberPages()
        {
            return numPages;
        }
    }
}
