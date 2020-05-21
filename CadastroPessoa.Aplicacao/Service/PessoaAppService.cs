using Aplicacao.Dto;
using Aplicacao.Interface;
using CadastroPessoa.Dominio.Entidade;
using CadastroPessoa.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Service
{
    public class PessoaAppService : IPessoaAppService
    {

        private readonly IClienteRepositorio _clienteRepositorio;

        public PessoaAppService(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public void CadastrarPessoa(CadastroPessoaDto cadastroPessoaDto)
        {
            var pessoa = new Pessoa(cadastroPessoaDto.Id, cadastroPessoaDto.Nome, cadastroPessoaDto.Sobrenome, cadastroPessoaDto.Documento, cadastroPessoaDto. Endereco);

            _clienteRepositorio.AdicionarOuAlterar(pessoa);

        }
    }
}
