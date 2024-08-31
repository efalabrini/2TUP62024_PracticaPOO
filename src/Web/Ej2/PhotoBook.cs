using System;

namespace Web.Ej2;

public class PhotoBook
{
    public int selfId {get;set;}
    protected int? numPages { get; set; }
    private static int id { get; set; } = 0;
    protected static List<PhotoBook> DataPhotoBook=[];

    public PhotoBook()

    {
        numPages = 16;
        selfId=PhotoBook.GenerateNewId();
        DataPhotoBook.Add(this);
    }


    public PhotoBook(int? _numPages)
    {
        numPages = _numPages;
        selfId=PhotoBook.GenerateNewId();
        DataPhotoBook.Add(this);
    }

    public int? GetNumberPages()
    {
        return numPages;
    }

    public static int GenerateNewId(){
        id++;
        return id;
    }

    public static List<PhotoBook> GetDataPhotoBooks(){
        return DataPhotoBook;
    }
}
