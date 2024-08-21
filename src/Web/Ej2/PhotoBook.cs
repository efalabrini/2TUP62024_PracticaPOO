namespace Web.Ej2;

public class PhotoBook
{
    private static int _nextId = 0;
    public int Id { get; private set;}
    protected int NumPages { get; set; }

    public PhotoBook()
    {
        NumPages = 16;
        Id = _nextId++;
    }
    public PhotoBook(int pages)
    {
        NumPages = pages;
        Id = _nextId++;
    }

    public int GetNumberPages()
    {
        return NumPages;
    }
}