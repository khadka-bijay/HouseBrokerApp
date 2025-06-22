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

        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyImage> PropertyImages { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<ApplicationUser>(entity =>
        //    {
        //        entity.Property(e => e.UserId)
        //            .ValueGeneratedOnAdd()
        //            .UseIdentityColumn();
                        
        //    });

        //    modelBuilder.Entity<Property>(entity =>
        //    {
        //        entity.HasKey(e => e.Id);
        //        entity.Property(e => e.Id)
        //            .ValueGeneratedOnAdd()
        //            .UseIdentityColumn();
        //    });

        //    modelBuilder.Entity<PropertyImage>(entity =>
        //    {
        //        entity.HasKey(e => e.Id);
        //        entity.Property(e => e.Id)
        //            .ValueGeneratedOnAdd()
        //            .UseIdentityColumn();
        //    });
        //}
    }
}
