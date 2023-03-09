using Domain;

namespace Entities.Library
{
    public class TCard : DbEntity
    {
        public Book? Book { get; set; }
        public Librarian? Librarian { get; set; }
        public Teacher? Teacher { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime? DateIn { get; set; }

        public Guid TeacherId { get; set; }
        public Guid BookId { get; set; }
        public Guid LibrarianId { get; set; }
    }
}
