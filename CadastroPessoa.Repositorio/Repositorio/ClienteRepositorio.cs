using CadastroPessoa.Dominio.Entidade;
using CadastroPessoa.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa.Repositorio.Repositorio
{
    public class ClienteRepositorio : AbstractRepositorio<Pessoa>, IClienteRepositorio
    {
        public void AdicionarOuAlterar(Pessoa pessoa)
        {
            AddOrUpdate(pessoa);
            SaveChanges();
        }
    }
}
