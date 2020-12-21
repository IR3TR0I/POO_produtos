using System;

namespace poo_produto.Classes
{
    public class usuario
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }
        
        public string Senha { get; set; }

        public string Email { get; set; }
        
        public DateTime DataCadastro { get; set; }
        public usuario(){
            Cadastrar();
        }

        public usuario(int _codigo, string _nome, string _email, string _senha){
            Codigo = _codigo;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            DataCadastro = DateTime.UtcNow;


        }


        public void Cadastrar(){
            Nome = "Ruan";
            Email = "ruangostoso@gmailaquelepique.com";
            Senha = "123456789";
            


            DataCadastro = DateTime.UtcNow;
        }

        public void Deletar(){
            Nome = "";
            Email = "";
            Senha = "";

            DataCadastro = DateTime.Parse("");
        }
    }
}