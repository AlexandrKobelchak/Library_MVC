using Domain;
using Entities.Library;

namespace Repositories.Abstract
{
    public interface IBookRepository : IDbRepository<Book>
    {
    }
}
