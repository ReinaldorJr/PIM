using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaPagamento.Classes
{
    internal class ListFunc
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Cargo { get; set; }
        public string Id { get; set; }

        public ListFunc(string nome, string cpf, string cargo, string id)
        {
            Nome = nome;
            Cpf = cpf;
            Cargo = cargo; 
            Id = id;
        }
    }
}
