using CadastroPessoa.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa.Repositorio.Interface
{
    public interface IClienteRepositorio
    {
        void AdicionarOuAlterar(Pessoa pessoa);
    }
}
