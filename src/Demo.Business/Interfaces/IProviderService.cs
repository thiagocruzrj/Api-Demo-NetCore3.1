using Demo.Business.Models;
using System;
using System.Threading.Tasks;

namespace Demo.Business.Interfaces
{
    public interface IProviderService : IDisposable
    {
        Task<bool> Add(Provider provider);
        Task<bool> Update(Provider provider);
        Task<bool> Remove(Guid id);

        Task UpdateAddress(Address address);
    }
}
