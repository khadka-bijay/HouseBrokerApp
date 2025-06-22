using FluentValidation;
using HouseBroker.API.Models;

namespace HouseBroker.API
{
    public static class DependencyRegistrar
    {
        public static void AddServices(this IServiceCollection services)
        {
            #region Validators
            services.AddTransient<IValidator<RegisterDto>, RegisterValidator>();
            #endregion
        }
    }
}
