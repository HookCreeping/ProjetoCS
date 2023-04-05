// Escreva um programa que pergunte o raio de uma circunferência e em
// seguida mostre o diâmetro, comprimento e área da circunferência.

// Raio = x | Diâmetro = 2x | Circunferência = 2x * pi | Área = x^2 * pi

Console.WriteLine($"Escreva o raio do círculo:");
float raio = float.Parse(Console.ReadLine()!);

float diametro = raio * 2;
float pi = (float)Math.PI;
float comprimento = pi * diametro;
double area = Math.Pow(raio, 2) * pi;

Console.WriteLine($"Diâmetro: {diametro}");
Console.WriteLine($"Comprimento: {comprimento}");
Console.WriteLine($"Área: {area}");
