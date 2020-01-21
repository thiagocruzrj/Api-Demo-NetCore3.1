using Demo.Business.Interfaces;
using Demo.Business.Models;
using Demo.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Demo.Data.Repository
{
    public class ProviderRepository : Repository<Provider>, IProviderRepository
    {
        public ProviderRepository(MyDbContext db) : base(db)
        {
        }

        public async Task<Provider> GetProviderAddress(Guid id)
        {
            return await _db.Providers.AsNoTracking()
                .Include(c => c.Address)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Provider> GetProviderProductsAddress(Guid id)
        {
            return await _db.Providers.AsNoTracking()
                .Include(c => c.Products)
                .Include(c => c.Address)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
