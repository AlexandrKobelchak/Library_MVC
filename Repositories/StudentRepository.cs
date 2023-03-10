using Entities.Library;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;
using Repositories.Generic;

namespace Repositories
{
    public class StudentRepository : DbRepository<Student>, IStudentRepository
    {
        public StudentRepository(DbContext context)
            : base(context)
        {
        }
    }
}
