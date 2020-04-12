using FluentValidation;
using FluentValidation.Results;
using SalesSystem.Business.Interfaces;
using SalesSystem.Business.Models;
using SalesSystem.Business.Notifications;

namespace SalesSystem.Business.Services
{
    public abstract class BaseService
    {
        private readonly INotificador _notificador;

        protected BaseService(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected void Notificar(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Notificar(error.ErrorMessage);
            }
        }

        protected void Notificar(string message)
        {
            _notificador.Handle(new Notificacao(message));
        }

        protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade) where TV : AbstractValidator<TE> where TE : Entity
        {
            var validador = validacao.Validate(entidade);
            if (validador.IsValid) return true;
            Notificar(validador);
            return false;
        }
    }
}
