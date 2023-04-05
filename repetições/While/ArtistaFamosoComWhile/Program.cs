// Qual é a idade do CR7?

bool idadeCerta = false;

while (idadeCerta == false) {
    Console.WriteLine($"Qual é a idade do CR7?");
    int idade = int.Parse(Console.ReadLine()!);

    if (idade == 38) {
        Console.WriteLine($"ACERTOU!");
        idadeCerta = true;
    } else {
        Console.WriteLine($"ERROU!");
    }
}