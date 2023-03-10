using Entities.Library;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;
using Repositories.Generic;

namespace Repositories
{
    public class SCardRepository : DbRepository<SCard>, ISCardRepository
    {
        public SCardRepository(DbContext context) : base(context)
        {
        }
    }
}
