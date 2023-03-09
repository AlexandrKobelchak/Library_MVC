using Domain;

namespace Entities.Library
{
    public class Student : DbEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
        public Group? Group { get; set; }
        public Guid GroupId { get; set; }

        public List<SCard>? SCards { get; set; }
    }
}
