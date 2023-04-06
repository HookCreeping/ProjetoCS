// Faça um programa que peça uma nota, entre zero e dez.
// Mostre uma mensagem caso o valor seja inválido e continue pedindo
// até que o usuário informe um valor válido.

Console.WriteLine($"Insira uma nota de 0 a 10");
bool notaCerta = false;

while (notaCerta == false) {
    int nota = int.Parse(Console.ReadLine()!);
    if (nota > 10){
        Console.WriteLine($"Nota inválida. a nota deve ser de 1 a 10!");
    } else {
        notaCerta = true;
        Console.WriteLine($"Sua nota é {nota}");
    }
}