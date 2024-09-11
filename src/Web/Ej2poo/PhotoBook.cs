namespace Web.Ej2poo{
    public class PhotoBook
    {
        public int id{get;set;}
        static int count = 1;
        public int numPages{get;set;}
        public PhotoBook (){
            numPages = 16;
            CreateId();
        }
        public PhotoBook(int pages){
            numPages = pages;
            CreateId();
        }
        public void CreateId(){
            id = count;
            count++;
        } 
        public int GetNumPages(){
            return numPages;
        }
    }
}
