using Domain;

namespace Entities.Library
{
    public class Category : DbEntity
    {
        public string? Name { get; set; }
        public List<Book>? Books { get; set; }
    }
}
