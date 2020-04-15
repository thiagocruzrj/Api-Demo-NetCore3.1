using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SalesSystem.Api.ViewModels;
using SalesSystem.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesSystem.Api.Controller
{
    [Route("api/fornecedores")]
    public class FornecedoresController : MainController
    {
        private readonly IFornecedorRepository _fornecedorRepository;
        private readonly IMapper _mapper;

        public FornecedoresController(IFornecedorRepository fornecedorRepository, IMapper mapper)
        {
            _fornecedorRepository = fornecedorRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<FornecedorViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<FornecedorViewModel>>(await _fornecedorRepository.ObterTodos());
        }

        public async Task<FornecedorViewModel> ObterPorId(Guid id)
        {
            return _mapper.Map<FornecedorViewModel>(await _fornecedorRepository.ObterPorId(id));
        }

        public async Task<FornecedorViewModel> ObterFornecedorProdutosEndereco(Guid id)
        {
            return _mapper.Map<FornecedorViewModel>(await _fornecedorRepository.ObterFornecedorProdutosEndereco(id));
        }
    }
}
