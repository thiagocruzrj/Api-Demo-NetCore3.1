using AutoMapper;
using Demo.Api.ViewModels;
using Demo.Business.Interfaces;
using Demo.Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Api.Controllers
{
    [Route("api/[controller]")]
    public class ProvidersController : MainController
    {
        private readonly IProviderRepository _providerRepository;
        private readonly IProviderService _providerService;
        private readonly IMapper _mapper;

        public ProvidersController(IProviderRepository providerRepository, IMapper mapper, IProviderService providerService)
        {
            _providerRepository = providerRepository;
            _mapper = mapper;
            _providerService = providerService;
        }

        [HttpGet]
        public async Task<IEnumerable<ProviderViewModel>> GetAll()
        {
            var provider = _mapper.Map<IEnumerable<ProviderViewModel>>(await _providerRepository.GetAll());
            return provider;
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<ProviderViewModel>> GetById(Guid id)
        {
            var provider = await GetProviderProductsAddress(id);

            if (provider == null) return NotFound();

            return provider;
        }

        [HttpPost]
        public async Task<ActionResult<ProviderViewModel>> Add(ProviderViewModel providerViewModel)
        {
            if (!ModelState.IsValid) return BadRequest();

            var provider = _mapper.Map<Provider>(providerViewModel);
            var result = await _providerService.Add(provider);

            if (!result) return BadRequest();

            return Ok(provider);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<ProviderViewModel>> Update(Guid id, ProviderViewModel providerViewModel)
        {
            if (id != providerViewModel.Id) return BadRequest();
            if (!ModelState.IsValid) return BadRequest();

            var provider = _mapper.Map<Provider>(providerViewModel);
            var result = await _providerService.Update(provider);

            if (!result) return BadRequest();

            return Ok(provider);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<ProviderViewModel>> Remove(Guid id)
        {
            var provider = await GetProviderAddress(id);
            if (provider == null) return NotFound();
            var result = await _providerService.Remove(id);

            if (!result) return BadRequest();

            return Ok(provider);
        }

        public async Task<ProviderViewModel> GetProviderProductsAddress(Guid id)
        {
            return _mapper.Map<ProviderViewModel>(await _providerRepository.GetProviderProductsAddress(id));
        }

        public async Task<ProviderViewModel> GetProviderAddress(Guid id)
        {
            return _mapper.Map<ProviderViewModel>(await _providerRepository.GetProviderAddress(id));
        }
    }
}
