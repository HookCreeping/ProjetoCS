// Faça um programa que receba um número inteiro e mostre a sua tabuada.

// número = x, tabuada = t. Toda vez que x for multiplicado por t, t
// deve aumentar +1, até ter valor de 10.

Console.WriteLine($"Digite um número inteiro para saber sua tabuada");
int x = int.Parse(Console.ReadLine()!);

for (int y = 1; y <= 10; y++) {
    Console.WriteLine(x * y);
}