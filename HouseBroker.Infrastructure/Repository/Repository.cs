using HouseBroker.Infrastructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HouseBroker.Infrastructure.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly HouseBrokerDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(HouseBrokerDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<IList<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public DbSet<T> Table()
        {
            return _dbSet;
        }
    }

}
