using Demo.Business.Interfaces;
using Demo.Business.Models;
using Demo.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Data.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(MyDbContext db) : base(db)
        {
        }

        public async Task<Product> GetProductProvider(Guid id)
        {
            return await _db.Products.AsNoTracking().Include(f => f.Provider).FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Product>> GetProductsByProvider(Guid providerId)
        {
            return await Search(p => p.ProviderId == providerId);
        }

        public async Task<IEnumerable<Product>> GetProductsProviders()
        {
            return await _db.Products.AsNoTracking().Include(f => f.Provider).OrderBy(p => p.Name).ToListAsync();
        }
    }
}
