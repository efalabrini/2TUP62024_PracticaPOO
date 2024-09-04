using Microsoft.AspNetCore.Mvc;

namespace Web.Ej2;

public class BigPhotoBook : PhotoBook
{
    public BigPhotoBook() : base(64)
    {
    }
}