using SalesSystem.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Api.Controller
{
    public class AuthController : MainController
    {
        public AuthController(INotificador notificador) : base(notificador)
        {
        }
    }
}
