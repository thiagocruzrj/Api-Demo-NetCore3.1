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

        public ProvidersController(IProviderRepository providerRepository, IMapper mapper, IProviderService providerService, INotifier notifier) : base(notifier)
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
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _providerService.Add(_mapper.Map<Provider>(providerViewModel));

            return CustomResponse(providerViewModel);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<ProviderViewModel>> Update(Guid id, ProviderViewModel providerViewModel)
        {
            if (id != providerViewModel.Id)
            {
                NotifyError("The given ID is not the same as the one passed in the query");
                return CustomResponse(providerViewModel);
            }
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _providerService.Update(_mapper.Map<Provider>(providerViewModel));

            return CustomResponse(providerViewModel);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<ProviderViewModel>> Remove(Guid id)
        {
            var providerViewModel = await GetProviderAddress(id);
            if (providerViewModel == null) return NotFound();
            await _providerService.Remove(id);

            return CustomResponse(providerViewModel);
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
