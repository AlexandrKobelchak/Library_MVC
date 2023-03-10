using Entities.Library;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;
using Repositories.Generic;

namespace Repositories
{
    public class ThemeRepository : DbRepository<Theme>, IThemeRepository
    {
        public ThemeRepository(DbContext context) : base(context)
        {
        }
    }
}
