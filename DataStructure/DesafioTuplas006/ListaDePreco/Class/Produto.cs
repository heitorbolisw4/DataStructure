using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ListaDePreco.Class
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto(int id, string nome, decimal preco)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
        }
        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;

        }

    }
}
