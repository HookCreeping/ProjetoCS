// . Fazer um programa que carregue 1 array, de 6 espaços.
// . Cada espaço será colocado um número, sendo ele inteiro.
// . No final, imprimir esses números, verificando qual é par/impar.
// . Imprimir a quantidade de pares e ímpares no final.

// BÔNUS: Par de Azul | ímpar de Verde

int[] numero = new int[6];
int pares = 0;
int impares = 0;
int zeros = 0;

for (int i = 0; i < 6; i++){
    Console.WriteLine($"Digite um número:");
    numero[i] = int.Parse(Console.ReadLine()!);

    if ((numero[i] % 2 == 0) && (numero[i] > 0)) {
        pares ++;
    } else if (numero[i] % 2 == 1) {
        impares++;
    } else {
        zeros++;
    }
}

foreach (int x in numero){
    if ((x % 2 == 0) && (x > 0)) {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"O número {x} é PAR");
        Console.ResetColor();
    } else if (x == 0) {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"O número é 0");
        Console.ResetColor();
    } else {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"o número {x} é IMPAR");
        Console.ResetColor();
    }
}

Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine(@$"

São {pares} Pares e {impares} Impares");
Console.ResetColor();

if (zeros >= 1) {
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine($"Houveram {zeros} numeros 0 durante o comando. ");
    Console.ResetColor();
}