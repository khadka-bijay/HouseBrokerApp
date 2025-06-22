using HouseBroker.Infrastructure.Entities;
using HouseBroker.Infrastructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HouseBroker.Application.Services
{
    public class PropertyService : IPropertyService
    {
        private readonly IRepository<Property> _propertyRepository;
        private readonly IUnitOfWork _unitOfWork;

        public PropertyService(
            IRepository<Property> propertyRepository,
            IUnitOfWork unitOfWork)
        {
            _propertyRepository = propertyRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Property>> GetAllAsync()
        {
            return await _propertyRepository.Table()
                    .Include(x => x.Images)
                    .Include(x => x.Broker)
                    .ToListAsync();
        }

        public async Task<Property> GetByIdAsync(int id)
        {
            return await _propertyRepository.Table()
                    .Include(x => x.Images)
                    .Include(x => x.Broker)
                    .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task CreateAsync(Property entity)
        {
            await _propertyRepository.AddAsync(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(Property entity)
        {
            entity.UpdatedOn = DateTime.Now;
            _propertyRepository.Update(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            Property? propertyToDelete = await _propertyRepository.Table().FirstOrDefaultAsync(x => x.Id == id);
            if(propertyToDelete is not null)
            {
                _propertyRepository.Delete(propertyToDelete);
                await _unitOfWork.SaveChangesAsync();
            }
        }
    }
}
