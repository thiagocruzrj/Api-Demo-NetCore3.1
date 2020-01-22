using Demo.Business.Interfaces;
using Demo.Business.Models;
using Demo.Business.Models.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Business.Services
{
    public class ProviderService : BaseService, IProviderService
    {
        private readonly IProviderRepository _providerRepository;
        private readonly IAddressRepository _addressRepository;
        public ProviderService(IProviderRepository providerRepository, IAddressRepository addressRepository, INotifier notifier) : base(notifier)
        {
            _providerRepository = providerRepository;
            _addressRepository = addressRepository;
        }

        public async Task<bool> Add(Provider provider)
        {
            if (!ExecultValidation(new ProviderValidation(), provider)
                || !ExecultValidation(new AddressValidation(), provider.Address)) return false;

            if(_providerRepository.Search(f => f.Document == provider.Document).Result.Any())
            {
                Notify("There's a provider with that filled document");
                return false;
            }

            await _providerRepository.Add(provider);
            return true;
        }

        public async Task<bool> Update(Provider provider)
        {
            if (!ExecultValidation(new ProviderValidation(), provider)) return false;

            if (_providerRepository.Search(f => f.Document == provider.Document && f.Id == provider.Id).Result.Any())
            {
                Notify("There's a provate with that filled document");
            }

            await _providerRepository.Update(provider);
            return true;
        }

        public async Task UpdateAddress(Address address)
        {
            if (!ExecultValidation(new AddressValidation(), address)) return;

            await _addressRepository.Update(address);
        }

        public async Task<bool> Remove(Guid id)
        {
            if(_providerRepository.GetProviderProductsAddress(id).Result.Products.Any())
            {
                Notify("The provider has registered products!");
            }

            var address = await _addressRepository.GetAddressByProvider(id);

            if( address != null)
            {
                await _addressRepository.Remove(id);
            }

            await _providerRepository.Remove(id);
            return true;
        }

        public void Dispose()
        {
            _providerRepository?.Dispose();
            _addressRepository?.Dispose();
        }
    }
}
