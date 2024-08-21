namespace Web.Ej2
{
    public class PhotoBook
    {
        private static int _nextId = 1;
        public int Id { get; set; }
        protected int NumPages {  get; set; }
       

        public PhotoBook()
        {
            NumPages = 16;
        }

        public PhotoBook(int pages)
        {
            NumPages = pages;
            Id = _nextId++;
        }
        public int GetNumberPages()
        {
            return NumPages;
        }
    }
}
