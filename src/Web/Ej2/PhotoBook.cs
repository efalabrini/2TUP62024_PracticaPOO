//using System.ComponentModel.DataAnnotations;

namespace Web.Ej2
{
    public class PhotoBook
    {
        //[Key]
        public int Id { get; set; }
        private static int IncrementId = 0; 
        protected int numPages { get; set; }

      
        public PhotoBook()
        {
            numPages = 16;
            Id = IncrementId++;
        }

        public PhotoBook(int pages)
        {
            numPages = pages;
            Id = IncrementId++;

        }
        public int GetNumberPages()
        {
            return numPages;
        }
        public string GetFormattedDetails()
        {
            return $"Book ID: {Id}, Number of Pages: {numPages}";
        }

    }
}
