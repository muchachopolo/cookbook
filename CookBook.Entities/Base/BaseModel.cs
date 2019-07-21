using System;
namespace CookBook.Entities.Base
{
    public abstract class BaseModel
    {
        public DateTime createAt { get; set; }
        public DateTime updateAt { get; set; }
    }
}
