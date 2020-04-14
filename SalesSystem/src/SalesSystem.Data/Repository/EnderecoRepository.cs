﻿using Microsoft.EntityFrameworkCore;
using SalesSystem.Business.Interfaces;
using SalesSystem.Business.Models;
using SalesSystem.Data.Context;
using System;
using System.Threading.Tasks;

namespace SalesSystem.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MeuDbContext context) : base(context) { }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking()
                .FirstOrDefaultAsync(f => f.FornecedorId == fornecedorId);
        }
    }
}
