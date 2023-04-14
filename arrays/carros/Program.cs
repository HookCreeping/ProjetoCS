// Contar carros usando FOREACH

string[] carros = new string[10];

for (int i = 0; i < 5; i++) {
    Console.WriteLine($"Digite uma marca de um carro:");
    carros[i] = Console.ReadLine()!;
}
for (int i = 0; i < 5; i++){
    Console.WriteLine($"O {i + 1}º carro é: {carros[i]}");
}