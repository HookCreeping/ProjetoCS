// Faça um programa que leia três números e mostre o maior e o menor deles.

// n1 = x, n2 = y e n3 = z. Escreva o maior

Console.WriteLine($"Digite o primeiro número:");
float x = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o segundo número:");
float y = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o terceiro número: ");
float z = float.Parse(Console.ReadLine()!);


if ((x > y) && (x > z)) {
    Console.WriteLine($"{x} é o maior número.");
    
} else if ((y > x) && (y > z)) {
    Console.WriteLine($"{y} é o maior número.");
    
} else {
    Console.WriteLine($"{z} é o maior número");
    
}