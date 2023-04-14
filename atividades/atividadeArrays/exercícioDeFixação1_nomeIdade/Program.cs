//exercício de fixação:
// Escreva um programa que receba e imprima o nome e idade de 5 pessoas
// !! RESPOSTA DEVE TER A SEGUINTE FORMATAÇÃO: 
// 
// 1-) Nome: xxx
//    Idade: yyy
// 
// 2-) Nome: zzz
//    Idade: ...

// Cores devem ser personalizadas: resposta do nome em azul e da idade 
// verde.




// algoritmo: 

// Nome = string | Idade = int
// 2 Arrays: Nome e Idade

string[] nomes = new string[5];
int[] idades = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o seu nome: ");
    nomes[i] = Console.ReadLine()!;

    Console.WriteLine($"Digite a sua idade: ");
    idades[i] = int.Parse(Console.ReadLine()!);
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{i + 1}-)");
    

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"Nome: {nomes[i]}");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(@$"Idade: {idades[i]}
    
    ");
    Console.ResetColor();
}