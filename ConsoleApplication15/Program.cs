using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            #region // CADASTRAR
            
            // variaveis produto
            Produto produto = new Produto();
            
            //variaveis fornecedor
            Fornecedor fornecedor = new Fornecedor();

            //menu cadastrar
            Console.WriteLine("Opções:\n1 - Cadastrar produto\n2 - Cadastrar fornecedor");
            Console.WriteLine("\nInforme a opção desejada: ");
            int opc = int.Parse(Console.ReadLine());
            
            switch(opc)
            {

                case 1:
                    Console.Clear();
                    
                    Console.WriteLine("Cadastro de Produto:\n");
                    
                    Console.WriteLine("Nome: ");
                    produto.Nome = Console.ReadLine();

                    Console.WriteLine("Fabricante: ");
                    produto.Fabricante = Console.ReadLine();

                    Console.WriteLine("Tipo: ");
                    produto.Tipo = Console.ReadLine();
                    
                    break;
                
                case 2:
                    
                    Console.Clear();
                    
                    Console.WriteLine("Cadastro de empresa:\n");
                    
                    Console.WriteLine("Razão social: ");
                    fornecedor.RazaoSocial = Console.ReadLine();

                    Console.WriteLine("Telefone: ");
                    fornecedor.Telefone = int.Parse(Console.ReadLine());

                    Console.WriteLine("Endereço: ");
                    fornecedor.Endereco = Console.ReadLine();

                    break;

                default:
                    Console.WriteLine("Opção Inválida");
                break;
            }
#endregion
#region //mostrar
           
            //menu mostrar 
            Console.WriteLine("Mostrar:\n ");
            Console.WriteLine("1 - Produto\n2 - Fornecedor");
            Console.WriteLine("Informe a opção desejada: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            { 
                case 1:
                    Console.Clear();

                    Console.WriteLine("Dados Produto:\n");
                    Console.WriteLine("Nome: " + produto.Nome);
                    Console.WriteLine("Fabricante: " + produto.Fabricante);
                    Console.WriteLine("Tipo: " + produto.Tipo);
                    break;
                
                case 2:
                    Console.Clear();

                    Console.WriteLine("Dados Fabricante:\n");
                    Console.WriteLine("Empresa: " + fornecedor.RazaoSocial);
                    Console.WriteLine("Telefone" + fornecedor.Telefone);
                    Console.WriteLine("Endereço" + fornecedor.Endereco);
                    break;

            }
            #endregion // MOSTRAR

        }
    }
}
