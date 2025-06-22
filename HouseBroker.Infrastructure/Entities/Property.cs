using HouseBroker.Infrastructure.Enums;

namespace HouseBroker.Infrastructure.Entities
{
    public class Property : BaseEntity
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public PropertyType? Type { get; set; }
        public string? Location { get; set; }
        public decimal? Price { get; set; }
        public string BrokerId { get; set; }
        public virtual ApplicationUser Broker { get; set; }
        public virtual IList<PropertyImage> Images { get; set; }
    }

}
