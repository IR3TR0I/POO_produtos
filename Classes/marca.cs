using System;
using System.Collections.Generic;

namespace poo_produto.Classes
{
    public class marca
    {
        public int Codigo { get; set; }

        public string NomeMarca { get; set; }

        public DateTime DataCadastro { get; set; }

        public List<marca> ListaDeMarcas = new List<marca>();

        public marca Cadastrar(){

            marca novaMarca = new marca();

            Console.WriteLine("Digite o codigo da marca");
            novaMarca.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da marca:");
            novaMarca.NomeMarca = Console.ReadLine();

            DataCadastro = DateTime.UtcNow;

            ListaDeMarcas.Add(novaMarca);

            return novaMarca;
        }

        public void Lista(){

            Console.ForegroundColor = ConsoleColor.Black;

            foreach (marca item in ListaDeMarcas)
            {
                System.Console.WriteLine($"Código: {item.Codigo}");
                System.Console.WriteLine($"Marca: {item.NomeMarca}");
                System.Console.WriteLine($"Data do Cadastro: {item.DataCadastro}");
            }

            Console.ResetColor();

        }
        
        
        public void Deletar(int cod){
            
            marca marcaDelete = ListaDeMarcas.Find(m => m.Codigo == cod);
            ListaDeMarcas.Remove(marcaDelete);
        }

        internal void Listar()
        {
            throw new NotImplementedException();
        }
    }
}