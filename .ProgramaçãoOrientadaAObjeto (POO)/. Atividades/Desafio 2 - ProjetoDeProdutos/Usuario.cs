using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_2___ProjetoDeProdutos
{
    public class Usuario
    {
        // atributos e propriedades
        public string? Codigo { get; private set; }
        public string? Nome { get; private set; }
        public string? Email { get; private set; }
        public string? Senha { get; private set; }
        public DateTime DataCadastro { get; set; }

        // métodos
        public Usuario() // $
        {
            Cadastrar();
        }

        public void Cadastrar() // $
        {
            this.Nome = "Usuário";
            this.Email = "email_email@email.com";
            this.Senha = "2444";
            this.DataCadastro = DateTime.Now;
        }

        public void Deletar() // $
        {
            this.Nome = "";
            this.Email = "";
            this.Senha = "";
            this.DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
        }
    }
}