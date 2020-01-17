using Demo.Business.Interfaces;
using Demo.Business.Models;
using Demo.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Repository
{
    public class ProductRepository : Repository<Product>, IProviderRepository
    {
        public ProductRepository(MyDbContext db) : base(db)
        {
        }

        public Task Add(Provider entity)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductProvider(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductsByProvider(Guid providerId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductsProviders()
        {
            throw new NotImplementedException();
        }

        public Task<Provider> GetProviderAddres(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Provider> GetProviderProductsAddress(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Provider>> Search(Expression<Func<Provider, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task Update(Provider entity)
        {
            throw new NotImplementedException();
        }

        Task<List<Provider>> IRepository<Provider>.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<Provider> IRepository<Provider>.GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
