using Entities.Library;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;
using Repositories.Generic;

namespace Repositories
{
    public class GroupRepository : DbRepository<Group>, IGroupRepository
    {
        public GroupRepository(DbContext context)
            : base(context)
        {
        }
    }
}
