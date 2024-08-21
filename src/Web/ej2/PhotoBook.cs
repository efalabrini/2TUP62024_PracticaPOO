using System;

namespace Web.ej2;

public class PhotoBook
{
    private int NumPages { get; set;}

    public PhotoBook()
    {
         NumPages = 16;
    }

     public PhotoBook(int pages)
    {
         NumPages = pages;
    }

    public int GetNumberPages()
    {
        return NumPages;
    }
}
