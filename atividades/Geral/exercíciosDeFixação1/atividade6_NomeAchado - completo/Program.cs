// 6 - Escreva um algoritmo que permita a leitura dos nomes de 
// 10 pessoas e armazene os nomes lidos em um vetor. Após isto,
// o algoritmo deve permitir a leitura de mais 1 nome qualquer de
// pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI,
// se o nome estiver entre os 10 nomes lidos anteriormente 
// (guardados no vetor), ou NÃO ACHEI caso contrário.

// algoritmo:

// array de 10 nomes
// buscar um nome no final



string[] nomes = new string[10];
bool achei = false;

for (int i = 0; i < 10; i++) {
    Console.WriteLine($"Digite um nome: ");
    nomes[i] =  Console.ReadLine()!.ToLower();
    Console.WriteLine($"");
}

for (int i = 0; i < 10; i = +10) {
    while (achei == false){
    Console.WriteLine($"Digite um nome para verificar se está na lista: ");
    string nome = Console.ReadLine()!.ToLower();
    Console.WriteLine($"");

    if (nome == nomes[i]) {
        Console.WriteLine($"ACHEI");
        achei = true;
        } else {
            Console.WriteLine($"NÃO ACHEI");
        }
    }
    
}