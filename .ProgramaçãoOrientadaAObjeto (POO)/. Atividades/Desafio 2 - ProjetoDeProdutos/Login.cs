using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_2___ProjetoDeProdutos
{
    public class Login
    {
        // atributos e propriedades
        public bool Logado { get; private set; }
        Usuario user = new Usuario();

        // métodos
        public Login() // $
        {

            Logar(user);

            if (this.Logado == true)
            {
                GerarMenu();
            }

        }

        public void Logar(Usuario _usuario) // $
        {
            Console.WriteLine($"Informe o email: ");
            string emailDigitado = Console.ReadLine()!;

            Console.WriteLine($"Informe a senha: ");
            string senhaDigitada = Console.ReadLine()!;

            if ((emailDigitado == _usuario.Email) && (senhaDigitada == _usuario.Senha)) // $
            {
                this.Logado = true;
                Console.WriteLine($"Login executado com sucesso!");
            }
            else // $
            {
                Deslogar();
            }
        }

        public void Deslogar() // $
        {
            this.Logado = false;
            Console.WriteLine($"Falha ao logar!");
        }

        public void GerarMenu() // $
        {
            Produto produto = new Produto();
            Marca marca = new Marca();

            string opcao;

            
            do // $
            {
            Console.ForegroundColor = ConsoleColor.Yellow;
            
                Console.WriteLine(@$"
            [1] - Cadastrar produto
            [2] - Listar produtos
            [3] - Remover Produto
            ------------------------
            [4] - Cadastrar Marca
            [5] - Listar Marcas
            [6] - Remover Marca
            
            [0] - Sair
            ");
                Console.ResetColor();

                opcao = Console.ReadLine()!;

                switch (opcao) // $
                {
                    case "1": // $
                        produto.Cadastrar();
                        break;

                    case "2": // $
                        produto.Listar();
                        break;

                    case "3": // $
                        Console.WriteLine($"Informe o código a ser excluido: ");
                        string codigoProduto = Console.ReadLine()!;

                        produto.Deletar(codigoProduto);
                        break;

                    case "4": // $
                        marca.Cadastrar();
                        break;

                    case "5": // $
                        marca.Listar();
                        break;

                    case "6": // $
                        Console.WriteLine($"Informe a marca a ser excluida: ");
                        string codigoMarca = Console.ReadLine()!;

                        marca.Deletar(codigoMarca);
                        break;

                    case "0": // $
                        this.Logado = false;

                        Console.WriteLine($"Encerrando...");

                        Thread.Sleep(3000);

                        Console.WriteLine($"");

                        Console.WriteLine($"Obrigado, volte sempre!");

                        break;
                    default: // $
                        Console.WriteLine($"Caractér inválido");
                        break;
                }
            } while (this.Logado == true);
        }
    }
}