using FluentValidation;
using Order.Domain.Entities;

namespace Order.Domain.Validations
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .Length(3, 30)
                .WithMessage("Name is required.");

            RuleFor(x => x.Email)
                .NotEmpty()
                .NotNull()
                .Length(10, 500)
                .EmailAddress(FluentValidation.Validators.EmailValidationMode.AspNetCoreCompatible)
                .WithMessage("Email is empty or unvailable.");

            RuleFor(x => x.Password)
                .NotEmpty()
                .NotNull()
                .WithMessage("Password is required.");

            RuleFor(x => x.Gender)
                .NotEmpty()
                .NotNull()
                .WithMessage("Gender is required.");

            RuleFor(x => x.BirthDate)
                .NotEmpty()
                .NotNull()
                .WithMessage("BirthDate is required.");
        }
    }
}
