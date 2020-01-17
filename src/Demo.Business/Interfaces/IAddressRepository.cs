using Demo.Business.Models;
using System;
using System.Threading.Tasks;

namespace Demo.Business.Interfaces
{
    public interface IAddressRepository : IRepository<Address>
    {
        Task<Address> GetAddressByProvider(Guid providerId);
    }
}
