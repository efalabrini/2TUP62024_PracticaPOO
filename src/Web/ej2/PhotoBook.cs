namespace Web.ej2 {

public class PhotoBook{

    protected int numPages {get; set;}
    public int id {get; set;}
    private static int idGen;

    public PhotoBook(){
        numPages = 16;
        idGen++;
        id = idGen;
    }
    public PhotoBook(int pages){
        numPages = pages;
        idGen++;
        id = idGen;
    }

    public int GetNumberPages(){
        return numPages;
    }

}
}