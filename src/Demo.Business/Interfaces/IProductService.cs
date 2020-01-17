using Demo.Business.Models;
using System;
using System.Threading.Tasks;

namespace Demo.Business.Interfaces
{
    public interface IProductService : IDisposable
    {
        Task Add(Product product);
        Task Update(Product product);
        Task Remove(Guid id);
    }
}
