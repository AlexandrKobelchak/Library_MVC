using Entities.Library;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;
using Repositories.Generic;

namespace Repositories
{
    public class LibrarianRepository : DbRepository<Librarian>, ILibrarianRepository
    {
        public LibrarianRepository(DbContext context) : base(context)
        {
        }
    }
}
