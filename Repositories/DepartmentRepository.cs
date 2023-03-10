using Entities.Library;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;
using Repositories.Generic;

namespace Repositories
{
    public class DepartmentRepository : DbRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(DbContext context) : base(context)
        {
        }
    }
}
