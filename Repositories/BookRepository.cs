using Entities.Library;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;
using Repositories.Generic;

namespace Repositories
{
    public class BookRepository : DbRepository<Book>, IBookRepository
    {
        public BookRepository(DbContext context) : base(context)
        {
        }
    }
}
