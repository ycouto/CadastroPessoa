using CadastroPessoa.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa.Repositorio.Repositorio
{
    public abstract class AbstractRepositorio<T> : IRepositorio<T> where T : class
    {
        public void AddOrUpdate(T entidade)
        {
            StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("ID,Nome,Sobrenome,Documento,Endereco");

            System.IO.File.WriteAllText(
                        System.IO.Path.Combine(
                        AppDomain.CurrentDomain.BaseDirectory, "Cliente.txt"),
                        sb.ToString());
        }
        public void Remove(T entidade) { }
        public void SaveChanges() { }
    }
}
