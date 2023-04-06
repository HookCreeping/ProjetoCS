

// As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia,
// e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas,
// calcule e escreva o valor total da compra.

// maças custam 0,30 reais. Quando são 12, o preço abaixa para 0,25 reais. se tiver 12 maças ou mais, 
// o valor é 0,25, senão, 0,30.

Console.WriteLine($"Quantas maçãs foram compradas no total?");
float maças = float.Parse(Console.ReadLine()!);

if (maças >= 12) {
    Console.WriteLine($"O valor total pago pelas {maças} maçãs foi {maças * 0.25} reais.");
    
} else {
    Console.WriteLine($"O valor total pago pelas {maças} maçãs foi {maças * 0.30} reais.");
    
}

