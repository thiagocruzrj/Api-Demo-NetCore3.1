using Demo.Business.Models;
using System;
using System.Threading.Tasks;

namespace Demo.Business.Interfaces
{
    public interface IProviderRepository : IRepository<Provider>
    {
        Task<Provider> GetProviderAddress(Guid id);
        Task<Provider> GetProviderProductsAddress(Guid id);
    }
}
