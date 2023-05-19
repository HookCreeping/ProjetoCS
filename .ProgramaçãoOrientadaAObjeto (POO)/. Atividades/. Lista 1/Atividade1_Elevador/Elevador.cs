using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade1_Elevador
{
    public class Elevador
    {
        // propriedades
        public int andarAtual { get; set; }
        public int capacidade { get; set; }

        // métodos
        public void Inicializa()
        {
            this.andarAtual = 0;
            this.capacidade = 0;
        }

        public void Entrar()
        {
            if (this.capacidade < 7)
            {
                this.capacidade++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"SEM ESPAÇO");
                Console.ResetColor();
            }
        }

        public void Sair()
        {
            if (this.capacidade > 0)
            {
                this.capacidade--;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"NÃO HÁ MAIS NINGUÉM NO ELEVADOR"); 
                Console.ResetColor();
            }
        }

        public void Subir()
        {
            if (this.andarAtual < 8)
            {
                this.andarAtual++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"JÁ ESTAMOS NO ÚTIMO ANDAR");
                Console.ResetColor();
            }
        }

        public void Descer()
        {
            if (this.andarAtual > 0)
            {
                this.andarAtual--;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"JÁ ESTAMOS NO PISO TÉRREO");
                Console.ResetColor();
            }
        }
    }
}