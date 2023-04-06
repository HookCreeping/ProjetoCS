// Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol
// (os gols de cada time) e informa se o resultado foi um empate, se a vitória foi
//  do primeiro time ou do segundo time.

// Time1 = x, Time 2 = y
// Se x > y, Time1 ganha. 
// Se x < y, Time2 ganha.
// Se x = y, Times empatam.

Console.WriteLine($"Diga o nome do primeiro time: ");
string time1 = Console.ReadLine()!;
Console.WriteLine($"Diga a pontuação do time {time1}");
int ponto1 = int.Parse(Console.ReadLine()!);


Console.WriteLine($"Diga o nome do segundo time: ");
string time2 = Console.ReadLine()!;
Console.WriteLine($"Diga a pontuação do time {time2}");
int ponto2 = int.Parse(Console.ReadLine()!);


if (ponto1 > ponto2) {
    Console.WriteLine($"O time {time1} ganhou a partida.");
    
} else if (ponto1 == ponto2) {
    Console.WriteLine($"Houve um empate na partida.");
    
} else {
    Console.WriteLine($"O time {time2} ganhou a partida.");
    
}