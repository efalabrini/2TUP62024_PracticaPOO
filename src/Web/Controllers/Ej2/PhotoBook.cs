using Microsoft.AspNetCore.Mvc;

namespace Web.Ej2;

public class PhotoBook
{
    private static int _idGenerated = 0;
    protected int numPages{get; set;}
    public int id{get; set;}
    
    public PhotoBook()
    {
        numPages = 16;
        id = _idGenerated++;
    }

    public PhotoBook(int pages)
    {
        numPages = pages;
        id = _idGenerated++;
    }

    public int GetNumberPages()
    {
        return numPages;
    }

}