using Entities.Library;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;
using Repositories.Generic;

namespace Repositories
{
    public class PressRepository : DbRepository<Press>, IPressRepository
    {
        public PressRepository(DbContext context) : base(context)
        {
        }
    }
}
