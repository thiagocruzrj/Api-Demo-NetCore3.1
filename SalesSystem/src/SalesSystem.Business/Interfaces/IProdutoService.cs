using SalesSystem.Business.Models;
using System;
using System.Threading.Tasks;

namespace SalesSystem.Business.Interfaces
{
    interface IProdutoService : IDisposable
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}
