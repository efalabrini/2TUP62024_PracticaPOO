
namespace Web.Ej2;

public class PhotoBook
{

    protected static int IdAutoincremental = 0;
    protected int NumPages { get; set; }
    public int Id { get; set; }
    public PhotoBook(int numPages)
    {
        Id = IdAutoincremental++;
        NumPages = numPages;
    }
    public PhotoBook()
    {
        Id = IdAutoincremental++;
        NumPages = 16;
    }

    public int GetNumberPages()
    {
        return NumPages;
    }
}