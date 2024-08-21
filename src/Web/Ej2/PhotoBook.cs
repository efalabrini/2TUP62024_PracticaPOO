namespace Web.Ej2
{
    public class PhotoBook
    {
        private static int _nextId = 1;
        public int Id {  get; private set; }
        public int NumPages  { get; set; }

        public PhotoBook() : this(16) 
        {
            
        }
       
        public PhotoBook(int numPages)
        {
            NumPages = numPages;
            Id = _nextId++;
        }
       
        public int GetNumPages()
        {
            return NumPages;
        }
    }
}
