using CadastroPessoa.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Dto
{
    public class CadastroPessoaDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public Documento Documento { get; set; }
        public Endereco Endereco { get; set; }
    }
}
