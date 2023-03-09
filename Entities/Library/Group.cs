using Domain;

namespace Entities.Library
{
    public class Group : DbEntity
    {
        public string? Name { get; set; }
        public Faculty? Faculty { get; set; }
        public List<Student>? Students { get; set; }
        public Guid FacultyId { get; set; }
    }
}
