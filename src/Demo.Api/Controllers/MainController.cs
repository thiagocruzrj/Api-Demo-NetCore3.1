using Demo.Api.ViewModels;
using Demo.Business.Interfaces;
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

    [Route("api/[controller]")]
    public class ProvidersController : MainController
    {
        private readonly IProviderRepository _providerRepository;

        public ProvidersController(IProviderRepository providerRepository)
        {
            _providerRepository = providerRepository;
        }

        public async Task<IEnumerable<ProviderViewModel>> GetAll()
        {
            var provider = await _providerRepository.GetAll();

            return Ok(provider);
        }
    }
}
