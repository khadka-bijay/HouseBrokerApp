using HouseBroker.Infrastructure.Entities;

namespace HouseBroker.Application.Services
{
    public interface IPropertyService
    {
        Task<List<Property>> GetAllAsync();
        Task<Property> GetByIdAsync(int id);
        Task CreateAsync(Property entity);
        Task UpdateAsync(Property entity);
        Task DeleteAsync(int id);
    }
}
