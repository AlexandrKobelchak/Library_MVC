using Domain;

namespace Entities.Library
{
    public class Theme : DbEntity
    {
        public string? Name { get; set; }
        public List<Book>? Books { get; set; }
    }
}
