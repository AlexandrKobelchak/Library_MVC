using Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Library
{
    public class Librarian : DbEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
       
        public List <TCard>? TCards { get; set; }
        public List<SCard>? SCards { get; set; }
    }
}
