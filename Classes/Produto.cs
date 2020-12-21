using System;
using System.Collections.Generic;

namespace poo_produto.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        
        public string NomeProduto { get; set; }

        public float Preco { get; set; }
        
        public DateTime DataCadastro { get; set; }
        
        public marca Marca = new marca();

        internal usuario CadastroPor { get; private set; }

        public usuario Usuario = new usuario();

        public List<Produto> ListaDeProdutos = new List<Produto>();

        public void Cadastrar(){
            

            Produto novoProduto = new Produto();

            Console.WriteLine("Digite o código do produto;");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o nome do produto: ");
            novoProduto.NomeProduto = Console.ReadLine();

            Console.WriteLine($"Digite o preco do produto: ");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            DataCadastro =DateTime.UtcNow;

            novoProduto.Marca = Marca.Cadastrar();

            novoProduto.CadastroPor = new usuario();
            ListaDeProdutos.Add(novoProduto);
        }
        
        
        public void Listar(){
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (Produto item in ListaDeProdutos)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Nome do produto: {item.NomeProduto}");
                Console.WriteLine($"Preco: {item.Preco}");
                Console.WriteLine($"Data do Cadastro: {item.DataCadastro}");
                Console.WriteLine($"Marca: {item.Marca.NomeMarca}");
                Console.WriteLine($"Cadastrado pro: {item.Usuario.Nome}");

                Console.ResetColor();
            }
            
        }
        
        public void Deletar(int cod){

            Produto prodDelete =  ListaDeProdutos.Find(p => p.Codigo == cod);
            ListaDeProdutos.Remove(prodDelete);
        }

        internal void Deletar(object codigoProduto)
        {
            throw new NotImplementedException();
        }
    }
}