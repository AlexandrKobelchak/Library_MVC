namespace Entities.Library
{
    public class AuthorBookRelation
    {
        public Author? Author { get; set; }
        public Book? Book { get; set; }

        public Guid AuthorId { get; set; }
        public Guid BookId { get; set; }
    }
}
