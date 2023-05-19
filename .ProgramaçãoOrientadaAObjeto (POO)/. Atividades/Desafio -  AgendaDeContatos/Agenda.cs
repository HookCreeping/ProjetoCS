using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts
{
    public class Agenda : Contato, IAgenda
    {
        // propiedades
        List<Contato> contatos = new List<Contato>();

        // métodos
        public void Criar()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Digite o nome:");
            Console.ForegroundColor = ConsoleColor.Green;
            Nome = Console.ReadLine()!;

            Console.WriteLine($"");


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Digite o telefone: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Telefone = Console.ReadLine()!;

            Console.WriteLine($"");


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Digite o email");
            Console.ForegroundColor = ConsoleColor.Green;
            Email = Console.ReadLine()!;


            bool box = true;
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(@$"");
                Console.ForegroundColor = ConsoleColor.Green;
                string opcao = Console.ReadLine()!;

                if (opcao == "1")
                {
                    
                }
                else if (opcao == "2")
                {

                }
                else
                {

                }
            } while (box == true);
            box = true;

            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(@$"");
                Console.ForegroundColor = ConsoleColor.Green;
                string opcao = Console.ReadLine()!;

                if (opcao == "1")
                {

                }
                else if (opcao == "2")
                {

                }
                else
                {

                }
            } while (box == true);
            box = true;
        }
        public void Adicionar(Contato _contato)
        {
            contatos.Add(_contato);
        }

        public void Listar()
        {
            if (contatos.Count > 0)
            {

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Não há nenhum contato salvo!");
                Console.ResetColor();
            }
        }
    }
}
