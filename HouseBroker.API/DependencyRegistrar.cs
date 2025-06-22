using FluentValidation;
using HouseBroker.API.Models;
using HouseBroker.Infrastructure.Repository.Interfaces;
using HouseBroker.Infrastructure.Repository;
using HouseBroker.Application.Services;

namespace HouseBroker.API
{
    public static class DependencyRegistrar
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            #region Services
            services.AddScoped<IPropertyService, PropertyService>();
            #endregion

            #region ServiceRules
            #endregion

            #region Validators
            services.AddTransient<IValidator<RegisterDto>, RegisterValidator>();
            services.AddTransient<IValidator<PropertySaveModel>, PropertySaveModelValidator>();
            #endregion
        }
    }
}
