using Aplicacao.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Interface
{
    public interface IPessoaAppService
    {
        void CadastrarPessoa(CadastroPessoaDto cadastroPessoaDto);
    }
}
