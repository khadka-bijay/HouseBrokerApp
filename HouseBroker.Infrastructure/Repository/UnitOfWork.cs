using HouseBroker.Infrastructure.Repository.Interfaces;

namespace HouseBroker.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HouseBrokerDbContext _context;

        public UnitOfWork(HouseBrokerDbContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
