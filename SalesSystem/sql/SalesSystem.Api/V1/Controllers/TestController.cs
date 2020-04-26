using Microsoft.AspNetCore.Mvc;
using SalesSystem.Api.Controllers;
using SalesSystem.Business.Interfaces;

namespace SalesSystem.Api.V1.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/teste")]
    public class TesteController : MainController
    {

        public TesteController(INotificador notificador, IUser appUser) : base(notificador, appUser) { }

        [HttpGet]
        public string Valor()
        {
            return "Sou a V2";
        }
    }
}