using FluentValidation;

namespace Demo.Business.Models.Validations
{
    public class AddressValidation : AbstractValidator<Address>
    {
        public AddressValidation()
        {
            RuleFor(c => c.PublicPlace)
                .NotEmpty().WithMessage("The {PropertyName} field needs to be provided")
                .Length(2, 200).WithMessage("The {PropertyName} field must be between {MinLength} and {MaxLength} characters");

            RuleFor(c => c.Neighborhood)
                .NotEmpty().WithMessage("The {PropertyName} field needs to be provided")
                .Length(2, 100).WithMessage("The {PropertyName} field must be between {MinLength} and {MaxLength} characters");

            RuleFor(c => c.Cep)
                .NotEmpty().WithMessage("The {PropertyName} field needs to be provided")
                .Length(8).WithMessage("The {PropertyName} field must be {MaxLength} characters");

            RuleFor(c => c.City)
                .NotEmpty().WithMessage("A campo {PropertyName} precisa ser fornecida")
                .Length(2, 100).WithMessage("The {PropertyName} field must be between {MinLength} and {MaxLength} characters");

            RuleFor(c => c.State)
                .NotEmpty().WithMessage("The {PropertyName} field needs to be provided")
                .Length(2, 50).WithMessage("The {PropertyName} field must be between {MinLength} and {MaxLength} characters");

            RuleFor(c => c.Number)
                .NotEmpty().WithMessage("The {PropertyName} field needs to be provided")
                .Length(1, 50).WithMessage("The {PropertyName} field must be between {MinLength} and {MaxLength} characters");
        }
    }
}
