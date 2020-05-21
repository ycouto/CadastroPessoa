using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa.Modelos
{
    public class ClienteModel
    {
        private string _nome = string.Empty;
        private string _sobrenome = string.Empty;
        private string _documento = string.Empty;
        private string _endereco = string.Empty;

        public string Nome
        {
            get => _nome;
            set => SetField(ref _nome, value);
        }

        public string Sobrenome
        {
            get => _sobrenome;
            set => SetField(ref _sobrenome, value);
        }

        public string Documento
        {
            get => _documento;
            set => SetField(ref _documento, value);
        }

        public string Endereco
        {
            get => _endereco;
            set => SetField(ref _endereco, value);
        }
    }
}
