using AutoMapper;
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
        private readonly IMapper _mapper;

        public ProvidersController(IProviderRepository providerRepository, IMapper mapper)
        {
            _providerRepository = providerRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProviderViewModel>> GetAll()
        {
            var provider = _mapper.Map<IEnumerable<ProviderViewModel>>(await _providerRepository.GetAll());
            return provider;
        }
    }
}
