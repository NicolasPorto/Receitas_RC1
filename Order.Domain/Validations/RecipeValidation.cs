using FluentValidation;
using Order.Domain.Entities;

namespace Order.Domain.Validations
{
    public class RecipeValidation : AbstractValidator<Recipe>
    {
        public RecipeValidation()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .NotNull()
                .Length(3,30)
                .WithMessage("Title is required.");

            RuleFor(x => x.DescriptionRecipe)
                .NotEmpty()
                .NotNull()
                .Length(10, 500)
                .WithMessage("Description is required.");

            RuleFor(x => x.TypeRecipe)
                .NotEmpty()
                .NotNull()
                .WithMessage("Type Recipe is required.");
        }
    }
}