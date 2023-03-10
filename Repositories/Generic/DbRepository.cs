using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Generic
{
    public class DbRepository<T> : IDbRepository<T> where T : class, IDbEntity
    {
        private DbContext _context;

        public DbRepository(DbContext context)
        {
            _context = context;
        }

        public IQueryable<T> AllItems => _context.Set<T>();

        public async Task<bool> AddItemAsync(T item)
        {
            await _context.Set<T>().AddAsync(item);
            return await SaveChangesAsync() > 0; 
        }

        public async Task<int> AddItemsAsync(IEnumerable<T> items)
        {
            await _context.Set<T>().AddRangeAsync(items);
            return await SaveChangesAsync();
        }

        public async Task<bool> DeleteItemAsync(Guid id)
        {
            T? candidate = await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
            if (candidate == null)
            {
                return false;
            }
            _context.Set<T>().Remove(candidate);
            return await SaveChangesAsync() > 0;
        }

        public async Task<T?> GetItemAsync(Guid id)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<List<T>> ToListAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<bool> UpdateItemAsync(T item)
        {
            //_context.Entry(item).State= EntityState.Modified;
            _context.Set<T>().Update(item);
            return await SaveChangesAsync() > 0;
        }
        public async Task<int> SaveChangesAsync()
        {
            try
            {
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return -1;
            }
        }    
    }
}
