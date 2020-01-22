using Demo.Business.Interfaces;
using Demo.Business.Notifications;
using Microsoft.AspNetCore.Mvc; 
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Linq;

namespace Demo.Api.Controllers
{
    [ApiController]
    public abstract class MainController : ControllerBase
    {
        private readonly INotifier _notifier;

        protected MainController(INotifier notifier)
        {
            _notifier = notifier;
        }

        protected bool ValidOperation()
        {
            return !_notifier.HasNotification();
        }

        protected ActionResult CustomReposonse(object result = null)
        {
            if(ValidOperation())
            {
                return Ok(new
                {
                    success = true,
                    data = result
                });
            }

            return BadRequest(new
            {
                success = false,
                errors = _notifier.GetNotifications().Select(n => n.Message)
            });
        }

        protected ActionResult CustomReposonse(ModelStateDictionary modelSate)
        {
            if (!modelSate.IsValid) NotifyErrorInvalidModel(modelSate);
            return CustomReposonse();
        }

        protected void NotifyErrorInvalidModel(ModelStateDictionary modelState)
        {
            var errors = modelState.Values.SelectMany(e => e.Errors);
            foreach (var error in errors)
            {
                var errorMsg = error.Exception == null ? error.ErrorMessage : error.Exception.Message;
                NotifyError(errorMsg);
            }
        }

        protected void NotifyError(string message)
        {
            _notifier.Handle(new Notification(message));
        }
    }
}
