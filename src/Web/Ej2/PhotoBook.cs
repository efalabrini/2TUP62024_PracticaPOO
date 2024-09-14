namespace Web.Ej2
{
    public class PhotoBook
    {

        protected static int AutoincrementId = 0;

        protected int NumPages { get; set; }
        public int Id { get; set; }

        public PhotoBook()
        {
            NumPages = 16;
            AutoincrementId++;
            Id = AutoincrementId;
        }

        public PhotoBook(int numPages)
        {
            NumPages = numPages;
            AutoincrementId++;
            Id = AutoincrementId;
        }

        public int GetNumberPages() { return NumPages; }

    }
}