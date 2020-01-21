using Demo.Api.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Api.Controllers
{
    [ApiController]
    public abstract class MainController : ControllerBase
    {
        // notification errors validation 
        // ModelState validate
        // Business operation validation
    }

    //[Route("api/[controller]")]
    //public class ProvidersController : MainController
    //{
    //    public async Task<IEnumerable<ProviderViewModel>> GetAll()
    //    {

    //    }
    //}
}
