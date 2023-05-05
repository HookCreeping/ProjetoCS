using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade2_MáquinaCafé
{
    public class MaquinaCafé
    {
        // propriedades
        public int acucarDisponivel { get; set; }
        private int acucarRestante { get; set; }

        // métodos
        public void Inicializa()
        {
            acucarDisponivel = 2000;

            Thread.Sleep(3000);
        }

        public void FazerCafe(int x)
        {
            this.acucarRestante = acucarDisponivel - x;

            if (acucarRestante <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@$"
   -----------------------------------------------             
   |  !   !   !   !   !   !   !   !   !   !   !  |
   | A MÁQUINA ESTÁ SEM AÇÚCAR                   |
   |                                             |
   | - Permitido apenas: Café sem açúcar         |
   | até o reestoque de açúcar.                  |
   -----------------------------------------------
   ");
                Console.ResetColor();

                Thread.Sleep(3000);
            }
            else
            {
                Console.Beep(1000, 600);
                Thread.Sleep(600);
                Console.Beep(1000, 600);
                Thread.Sleep(600);
                Console.Beep(1000, 600);
                Thread.Sleep(600);

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine(@$"
Café feito");
                Thread.Sleep(3000);
                Console.WriteLine(@$"
Boa Degustação");

                Console.ResetColor();
                Thread.Sleep(3000);
            }
        }

        public void FazerCafe()
        {
            Console.WriteLine($"Padrão do sistema: 10g de açúcar");
            Thread.Sleep(3000);


            this.acucarDisponivel = 2000;

            this.acucarRestante = acucarDisponivel - 10;

            if (acucarRestante <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@$"
   -----------------------------------------------             
   |  !   !   !   !   !   !   !   !   !   !   !  |
   | A MÁQUINA ESTÁ SEM AÇÚCAR                   |
   |                                             |
   | - Permitido apenas: Café sem açúcar         |
   | até o reestoque de açúcar.                  |
   -----------------------------------------------
   ");
                Console.ResetColor();

                Thread.Sleep(3000);
            }
            else
            {
                Console.Beep(1000, 600);
                Thread.Sleep(600);
                Console.Beep(1000, 600);
                Thread.Sleep(600);
                Console.Beep(1000, 600);
                Thread.Sleep(600);

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine(@$"
Café feito");
                Thread.Sleep(3000);
                Console.WriteLine(@$"
Boa Degustação");

                Console.ResetColor();
                Thread.Sleep(3000);
            }
        }

        public void Reestoque()
        {
            Console.WriteLine(@$"
            Quantos gramas de açúcar você deseja reestocar?
            ");

            int reestoque = int.Parse(Console.ReadLine()!);

            int total = acucarDisponivel + reestoque;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Thread.Sleep(3000);

            Console.WriteLine(@$"
            {reestoque}g de açúcar adicionados na máquina

            {total}g de açúcar disponíveis.
            ");

            Console.ResetColor();
            Thread.Sleep(3000);
        }
    }
}