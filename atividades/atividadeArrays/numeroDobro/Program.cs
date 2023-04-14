// // Criar um programa que receba 5 números.
// // No final, escrever o dobro dos 5.

//!! USAR ARRAYS
//!! USAR FOREACH


// algoritmo:
// int = x. Escrever x * 2 no final.


int[] x = new int[5];

for (int i = 0; i < 5; i++){
    Console.WriteLine($"Digite o {i + 1}º número: ");
    x[i] = int.Parse(Console.ReadLine()!);
}

foreach (int numero in x){
    Console.WriteLine($" O dobro do número {numero} é {numero * 2}");
}