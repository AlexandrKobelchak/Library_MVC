using Domain;

namespace Entities.Library
{
    public class Teacher : DbEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Department? Department { get; set; }
        public Guid DepartmentId { get; set; }

        public List<TCard>? TCards { get; set; }
    }
}
