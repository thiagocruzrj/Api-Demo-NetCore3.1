﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using SalesSystem.Business.Interfaces;
using SalesSystem.Business.Notifications;
using System;
using System.Linq;

namespace SalesSystem.Api.Controller
{
    [ApiController]
    public abstract class MainController : ControllerBase
    {
        private readonly INotificador _notificador;

        protected MainController(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected ActionResult CustomResponse(ModelStateDictionary modelState)
        {

        }

        protected void NotificarErrorModelStateInvalida(ModelStateDictionary modelState)
        {
            var erros = modelState.Values.SelectMany(e => e.Errors);
            foreach (var erro in erros)
            {
                var erroMessage = erro.Exception == null ? erro.ErrorMessage : erro.Exception.Message;
                NotificarErro(erroMessage);
            }
        }

        protected void NotificarErro(string mensagem)
        {
            _notificador.Handle(new Notificacao(mensagem));
        }
    }
}
