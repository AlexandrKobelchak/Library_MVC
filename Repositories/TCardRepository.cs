using Entities.Library;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;
using Repositories.Generic;

namespace Repositories
{
    public class TCardRepository : DbRepository<TCard>, ITCardRepository
    {
        public TCardRepository(DbContext context) : base(context)
        {
        }
    }
}
