namespace Web.Ej2
{
    public class PhotoBook
    {
        public int Id { get; set; }
        private static int count = 1;
        public int numPages { get; set; }
        public PhotoBook()
        {
            numPages = 16;
            CreateId();
        }
        public PhotoBook(int pages)
        {
            numPages = pages;
            CreateId();
        }
        public void CreateId()
        {
            Id = count;
            count++;
        }
        public int GetNumPages()
        {
            return numPages;
        }    
    }
}
