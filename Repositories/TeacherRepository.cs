using Entities.Library;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;
using Repositories.Generic;

namespace Repositories
{
    public class TeacherRepository : DbRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(DbContext context) : base(context)
        {
        }
    }
}
