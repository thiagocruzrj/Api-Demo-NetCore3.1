using Demo.Business.Interfaces;
using Demo.Business.Models;
using Demo.Data.Context;
using System;
using System.Threading.Tasks;

namespace Demo.Data.Repository
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(MyDbContext db) : base(db)
        {
        }

        public Task<Address> GetAddressByProvider(Guid providerId)
        {
            throw new NotImplementedException();
        }
    }
}
