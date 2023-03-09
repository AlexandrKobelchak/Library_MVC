using Domain;

namespace Entities.Library
{
    public class Book : DbEntity
    {
        public string? Name { get; set; }
        public int Quantity  { get; set;  }
        public string? Description { get; set; }


        public Theme? Theme { get; set; }
        public Category? Category { get; set; }
        public Press? Press { get; set; }
        public List<Author>? Authors { get; set; }
        public List<TCard>? TCards { get; set; }
        public List<SCard>? SCards { get; set; }

        public Guid CategoryId { get; set; }
        public Guid ThemeId { get; set; }
        public Guid PressId { get; set; }
    }
}
