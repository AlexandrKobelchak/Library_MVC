using Domain;

namespace Entities.Library
{
    public class Department : DbEntity
    {
        public string? Name { get; set; }
        public List<Teacher>? Teachers { get; set; }
    }
}
