namespace HouseBroker.Infrastructure.Entities
{
    public class PropertyImage : BaseEntity
    {
        public int PropertyId { get; set; }
        public virtual Property Property { get; set; }
        public string ImageUrl { get; set; }
    }
}
