public class PhotoBook
{
    private static int _idCounter = 1;
    public int Id { get; private set; }
    protected int numPages;

    public PhotoBook()
    {
        Id = _idCounter++;
        numPages = 16;
    }

    public PhotoBook(int pages)
    {
        Id = _idCounter++;
        numPages = pages;
    }

    public int GetNumberPages()
    {
        return numPages;
    }
}

