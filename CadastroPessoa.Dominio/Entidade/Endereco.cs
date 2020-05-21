using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa.Dominio.Entidade
{
    public class Endereco
    {
        public int Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
    }
}
