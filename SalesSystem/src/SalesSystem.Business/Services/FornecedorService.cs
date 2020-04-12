using SalesSystem.Business.Interfaces;
using SalesSystem.Business.Models;
using SalesSystem.Business.Models.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystem.Business.Services
{
    public class FornecedorService : BaseService, IFornecedorService
    {
        private readonly IFornecedorRepository _fornecedorRepository;
        private readonly IEnderecoRepository _enderecoRepository;

        public FornecedorService(IFornecedorRepository fornecedorRepository,
            IEnderecoRepository enderecoRepository,
            INotificador notificador) : base(notificador)
        {
            _fornecedorRepository = fornecedorRepository;
            _enderecoRepository = enderecoRepository;
        }

        public async Task<bool> Adicionar(Fornecedor fornecedor)
        {
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor)
                || !ExecutarValidacao(new EnderecoValidation(), fornecedor.Endereco)) return false;

            if(_fornecedorRepository.Buscar(f => f.Documento == fornecedor.Documento).Result.Any())
            {
                Notificar("Já existe um fornecedo com este documento informado.");
                return false;
            }

            await _fornecedorRepository.Adicionar(fornecedor);
            return true;
        }

        public Task<bool> Atualizar(Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarEndereco(Endereco endereco)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remover(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
