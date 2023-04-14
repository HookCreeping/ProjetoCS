// 4 - Faça um programa que leia 10 valores digitados pelo usuário e no 
// final, escreva o maior e o menor valor lido.

// algoritmo:

// usar arrays - se um inteiro for maior que outro, escrever ele depois.

int[] numero = new int[10];

for (int i = 0; i < 10; i++){
    Console.WriteLine($"Digite um número: ");
    numero[i] = int.Parse(Console.ReadLine()!);
}

Console.WriteLine($"O maior número é: {numero.Max()}");
Console.WriteLine($"O menor número é: {numero.Min()}");

