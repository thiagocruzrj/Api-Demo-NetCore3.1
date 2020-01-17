﻿using Demo.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Business.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductsByProvider(Guid providerId);
        Task<IEnumerable<Product>> GetProductsProviders();
        Task<Product> GetProductProvider(Guid id);
    }
}
