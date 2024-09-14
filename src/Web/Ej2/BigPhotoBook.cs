using Web.Ej2;

namespace Web.Ej2
{
    public class BigPhotoBook : PhotoBook
    {
        public BigPhotoBook()
        {
            NumPages = 64;
            Id = AutoincrementId;
        }
    }
}
