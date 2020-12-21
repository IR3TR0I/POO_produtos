using System;

namespace poo_produto.Classes
{
    public class Login
    {
        public Login(bool logado) 
        {
            this.Logado = logado;
               
        }
         public bool Logado { get; set; }



        public Login(){
            Logar();

            if(Logado == true){
                GerarMenu();
            }
        }

        public void GerarMenu(){

            Produto produto = new Produto();
            marca marca = new marca();
            string opcao = "n";
            do{
                Console.WriteLine("Escolha abaixo");
                Console.WriteLine("1 - Cadastrar Marca");
                Console.WriteLine("2 - Listar Marca");
                Console.WriteLine("3 - Excluir Marca");
                Console.WriteLine("4 - Cadstrar produto");
                Console.WriteLine("5 - Listar Produto");
                Console.WriteLine("6 - Excluir Marca");
                Console.WriteLine("0 - Sair");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        marca.Cadastrar();
                        break;

                    case "2":
                        marca.Listar();
                        break;

                    case "3":
                        Console.WriteLine("Digite um código para excluir a marca;");
                        int codigo = int.Parse(Console.ReadLine());
                        marca.Deletar(codigo);
                        break;

                    case "4":
                        produto.Cadastrar();
                        break;
                    case "5":
                        produto.Listar();
                        break;
                    case "6":
                        Console.WriteLine($"Digite um código para excluir um produto: ");
                        int codigoProduto = int.Parse(Console.ReadLine());
                        produto.Deletar(codigoProduto);
                        break;
                    default:
                        break;
                
                }
            }while(opcao != "0");
        }
        public void Logar(){
            usuario user = new usuario();
            do
           { Console.WriteLine("Digite seu email: ");
            string emailLogin = Console.ReadLine();

            Console.WriteLine($"Digite Sua Senha: ");
            string senhaLogin = Console.ReadLine();

            if(emailLogin == user.Email && senhaLogin == user.Senha){
                Logado = true;
                Console.WriteLine($"Login feito com sucesso");


            }else{
                Console.WriteLine($"Xii Deu errado aqui tem algo errado tenta de novo");
                
            }
            }while (Logado == false);
        }   
    }
}