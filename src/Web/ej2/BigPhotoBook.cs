using System;

namespace Web.ej2;

public class BigPhotoBook : PhotoBook
{
    private int NumPages {get; set;}

    public BigPhotoBook()
    {
        NumPages = 64;
    }
}

