using HouseBroker.Infrastructure.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HouseBroker.Infrastructure
{
    public class HouseBrokerDbContext: IdentityDbContext<ApplicationUser>
    {
        public HouseBrokerDbContext(DbContextOptions<HouseBrokerDbContext> options) : base(options) 
        {

        }
    }
}
