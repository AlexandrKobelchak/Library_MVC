using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Library
{
    public class Faculty: DbEntity
    {
       public string? Name { get; set; }
       public List<Group>? Groups { get; set; }
    }
}
