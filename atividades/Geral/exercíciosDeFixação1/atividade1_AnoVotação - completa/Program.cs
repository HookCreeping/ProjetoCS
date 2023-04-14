// 1 - Ler o ano atual e o ano de nascimento de uma pessoa. 
// Escrever uma mensagem que diga se ela poderá ou não votar este ano 
// (não é necessário considerar o mês em que a pessoa nasceu).

// algoritmo: 

// . Se pessoa tiver maior que 16 anos, pode votar. Senão, não pode.
// . Achar data.


Console.WriteLine($"VERIFICAÇÃO PARA VOTAÇÃO");
Console.WriteLine($"Insira o ano em que você nasceu: ");
int anoNascimento = int.Parse(Console.ReadLine()!);

int anoHoje = DateTime.Now.Year;

int Idade = anoHoje - anoNascimento;
if (Idade >= 16) {
    Console.WriteLine($"Você já pode votar.");   
} else {
    Console.WriteLine($"Segura a onda, você ainda não pode votar.");
}