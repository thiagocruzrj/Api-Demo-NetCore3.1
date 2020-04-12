﻿using SalesSystem.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesSystem.Business.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId);
        Task<IEnumerable<Produto>> ObterProdutosFornecedor();
        Task<Produto> ObterProdutoFornecedor(Guid id);
    }
}