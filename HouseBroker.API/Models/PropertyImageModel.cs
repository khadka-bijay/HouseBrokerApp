using FluentValidation;

namespace HouseBroker.API.Models
{
    public class PropertyImageModel
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public string ImageUrl { get; set; }
    }
}
