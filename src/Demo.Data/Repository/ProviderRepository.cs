using Demo.Business.Interfaces;
using Demo.Business.Models;
using Demo.Data.Context;
using System;
using System.Threading.Tasks;

namespace Demo.Data.Repository
{
    public class ProviderRepository : Repository<Provider>, IProviderRepository
    {
        public ProviderRepository(MyDbContext db) : base(db)
        {
        }

        public Task<Provider> GetProviderAddres(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Provider> GetProviderProductsAddress(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
