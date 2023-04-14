// 7 - Faça um algoritmo para ler 15 números e armazenar em um vetor. 
// Após a leitura total dos 15 números, o algoritmo deve escrever esses 
// 15 números lidos na ordem inversa da qual foi declarado.

int[] x = new int[15];



Console.WriteLine($"Escreva uma sequência de 15 números: ");
for (var i = 0; i < 15; i++) {
    x[i] = int.Parse(Console.ReadLine()!); 
}
Console.WriteLine($"");
Console.WriteLine($"");

Array.Reverse(x);
foreach (int numero in x) {
    Console.WriteLine(numero);
}