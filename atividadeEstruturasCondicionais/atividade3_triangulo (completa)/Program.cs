// Escreva um programa que leia as medidas dos lados de um triângulo e escreva
// se ele é Equilátero, Isósceles ou Escaleno, sendo que:
// − Triângulo Equilátero: possui os 3 lados iguais.
// − Triângulo Isóscele: possui 2 lados iguais.
// − Triângulo Escaleno: possui 3 lados diferentes.

// Lado1 = x, Lado2 = y, Lado3 = z
// Se x == y e y == z, Triângulo Equilátero
// Se x == y, mas y != z, Triângulo Isósceles
// Se x !-= y, y != z e x != z, Triângulo Escaleno

Console.WriteLine($"Digite o tamanho do primeiro lado do triângulo: ");
float lado1 = float.Parse(Console.ReadLine()!);
Console.WriteLine($"Digite o tamanho do segundo lado do triângulo: ");
float lado2 = float.Parse(Console.ReadLine()!);
Console.WriteLine($"Digite o tamanho do terceiro lado do triângulo: ");
float lado3 = float.Parse(Console.ReadLine()!);

if ((lado1 == lado2) && (lado2 == lado3)) {
    Console.WriteLine($"O triângulo é Equilátero.");
    
} else if ((lado1 == lado2 ) || (lado2 == lado3) || (lado3 == lado1)) {
    Console.WriteLine($"O triângulo é Isóceles");
    
} else {
    Console.WriteLine($"O triângulo é Escaleno");
    
}

