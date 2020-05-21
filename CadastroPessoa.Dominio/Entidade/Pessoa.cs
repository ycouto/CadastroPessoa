using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa.Dominio.Entidade
{
    public class Pessoa
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public Documento Documento { get; set; }
        public Endereco Endereco { get; set; }
        public override string ToString()
        {
            return this.Id.ToString() + "," + this.Nome + "," + this.Sobrenome + "," + this.Documento + "," + this.Endereco;
        }

        public Pessoa(Guid id, string nome, string sobrenome, Documento documento, Endereco endereco)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            Documento = documento;
            Endereco = endereco;
        }
    }
}
