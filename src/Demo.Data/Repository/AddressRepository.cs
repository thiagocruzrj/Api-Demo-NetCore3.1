using Demo.Business.Interfaces;
using Demo.Business.Models;
using Demo.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Demo.Data.Repository
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(MyDbContext db) : base(db)
        {
        }

        public async Task<Address> GetAddressByProvider(Guid providerId)
        {
            return await _db.Addresses.AsNoTracking().FirstOrDefaultAsync(f => f.ProviderId == providerId);
        }
    }
}
