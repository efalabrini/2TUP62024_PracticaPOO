namespace Web.Ej2
{
    public class PhotoBook
    {
        public int numPages {  get; set; }
        public int id { get; set; }
        
        static int cont = 0; 

        public PhotoBook() : this(16)
        { 
           
        } 

        public PhotoBook(int cantPages)
        {
            numPages = cantPages;
            id = getId();
        }

        public int GetNumberPages()
        {
            return numPages;
        }

        public int getId()
        { 
            return ++cont; 
        }
    }
}
