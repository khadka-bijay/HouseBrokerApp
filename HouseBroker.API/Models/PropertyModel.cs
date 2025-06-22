using FluentValidation;
using HouseBroker.Infrastructure.Enums;

namespace HouseBroker.API.Models
{
    public class PropertyModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public PropertyType? Type { get; set; }
        public string? Location { get; set; }
        public decimal? Price { get; set; }
        public string BrokerId { get; set; }
        public ApplicationUserModel Broker { get; set; }
        public IList<PropertyImageModel> Images { get; set; }
    }

    public class PropertySaveModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public PropertyType? Type { get; set; }
        public string? Location { get; set; }
        public decimal? Price { get; set; }
        public string BrokerId { get; set; }
        public IList<PropertyImageModel> Images { get; set; }
    }

    public class PropertySaveModelValidator : AbstractValidator<PropertySaveModel>
    {
        public PropertySaveModelValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Title is required.");

            RuleFor(x => x.BrokerId)
                .NotEmpty().WithMessage("BrokerId is required.");
        }
    }
}
