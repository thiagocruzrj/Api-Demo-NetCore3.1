using SalesSystem.Business.Models;
using System;
using System.Threading.Tasks;

namespace SalesSystem.Business.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}
