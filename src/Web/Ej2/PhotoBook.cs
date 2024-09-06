namespace Web.Ej2
{
    public class PhotoBook
    {

        //variable de clase
        protected static int _nextId = 0;
        

        //propiedades
        protected int _numPages { get; set; }
        protected int _id { get; set; }

        //constructores
        public PhotoBook()
        {
            //_nextId = _nextId + 1
            _id = ++_nextId ;
            _numPages = 16;
        }

        public PhotoBook(int numPages)
        {
            _id = ++_nextId;
            _numPages = numPages;
        }

        public int GetNumPages()
        {
            return this._numPages;
        }

        public int GetId()
        {
            return _id;
        }
    }
}
