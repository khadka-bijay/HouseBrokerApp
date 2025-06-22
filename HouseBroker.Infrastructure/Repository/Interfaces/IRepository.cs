using Microsoft.EntityFrameworkCore;

namespace HouseBroker.Infrastructure.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IList<T>> GetAllAsync();
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        DbSet<T> Table();
    }
}
