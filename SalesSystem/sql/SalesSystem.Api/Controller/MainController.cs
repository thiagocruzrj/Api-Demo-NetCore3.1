using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SalesSystem.Api.ViewModels;
using SalesSystem.Business.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesSystem.Api.Controller
{
    [ApiController]
    public abstract class MainController : ControllerBase
    {

    }

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
    }
}
