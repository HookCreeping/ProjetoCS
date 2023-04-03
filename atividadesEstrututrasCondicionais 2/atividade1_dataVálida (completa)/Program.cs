// Escreva um programa que pergunte o dia, mês e ano do aniversário de uma pessoa
// e diga se a data é válida ou não. Caso não seja, diga o motivo. 
// Suponha que todos os meses tem 31 dias e que estejamos no ano de 2013.

// DD/MM/AAAA. 
// Se o dia for maior que 31, está incorreto.
// Se o mês for maior que 12, está incorreto.
// Se o ano for maior que 2013, está incorreto.

Console.WriteLine($"Digite o dia em que você nasceu: ");
int dia = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o número do mês que você nasceu: ");
int mes = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o ano em que você nasceu: ");
int ano = int.Parse(Console.ReadLine()!);

if ((dia > 31) || (mes > 12) || (ano > 2013)) {
    Console.WriteLine($"Data incorreta. Reveja se a o dia, mês e o ano estão corretos e tente novamente.");
    
} else {
    Console.WriteLine($"Se hoje for {dia}/{mes}, parabéns pra você!");
    
}
