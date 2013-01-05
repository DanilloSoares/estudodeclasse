using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication15
{
    public class Fornecedor
    {
        public string RazaoSocial { get; set; }
        public int Telefone { get; set; }
        public string Endereco { get; set; }
        public List<Produto> Produtos { get; set; }
        
    }
}
