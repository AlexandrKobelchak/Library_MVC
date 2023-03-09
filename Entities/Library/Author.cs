using Domain;

namespace Entities.Library
{
    public class Author : DbEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public List<Book>? Books { get; set; }
    }
}
