using Entities.Library;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;
using Repositories.Generic;

namespace Repositories
{
    public class AuthorRepository : DbRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(DbContext context) : base(context)
        {
        }
    }
}
