using Demo.Business.Models.Validations.Documents;
using FluentValidation;

namespace Demo.Business.Models.Validations
{
    public class ProviderValidation : AbstractValidator<Provider>
    {
        public ProviderValidation()
        {
            RuleFor(f => f.Name)
                .NotEmpty().WithMessage("The {PropertyName} field needs to be provided")
                .Length(2, 100)
                .WithMessage("The {PropertyName} field must be between {MinLength} and {MaxLength} characters");

            When(f => f.ProviderType == ProviderType.PrivatePerson, () =>
            {
                RuleFor(f => f.Document.Length).Equal(CpfValidacao.TamanhoCpf)
                    .WithMessage("The Document field must be {ComparisonValue} characters and {PropertyValue} has been provided.");
                RuleFor(f => CpfValidacao.Validar(f.Document)).Equal(true)
                    .WithMessage("The document provided is invalid.");
            });

            When(f => f.ProviderType == ProviderType.LegalPerson, () =>
            {
                RuleFor(f => f.Document.Length).Equal(CnpjValidacao.TamanhoCnpj)
                    .WithMessage("The Document field must be {ComparisonValue} characters and {PropertyValue} has been provided.");
                RuleFor(f => CnpjValidacao.Validar(f.Document)).Equal(true)
                    .WithMessage("The document provided is invalid.");
            });
        }
    }
}
