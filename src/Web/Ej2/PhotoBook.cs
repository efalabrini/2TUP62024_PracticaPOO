namespace Web.Ej2
{
    public class PhotoBook
    {
        public int numPages { get; set; }
        public int id { get; }

        static int cont = 0;


        public PhotoBook() : this(16)
        {


        }

        public PhotoBook(int cantPages)
        {
            numPages = cantPages;
            id = GetId();
        }

        public int GetNumeroDePaginas()
        {
            return numPages;
        }

        static int GetId()
        {
            return ++cont;
        }
    }
}
