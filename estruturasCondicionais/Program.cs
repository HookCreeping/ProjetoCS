// // Condicional simples
// bool sol = true;
// if (sol){
//     Console.WriteLine($"Vou para a praia!");
// }


// // Condicional composta
// valor do sistema
// bool sol = false;
// if (sol) {
//     Console.WriteLine($"Eu vou dormir.");
// } else {
//     Console.WriteLine("Vou para a praia!");
// }

// valor do usuário
// Console.WriteLine($"O dia está quente hoje? Digite Sim ou Não.");
// string sol = Console.ReadLine()!.ToUpper();

// Console.WriteLine($"Estou de folga hoje? Digite Sim ou Não.");
// string folga = Console.ReadLine()!.ToUpper();

// if ((sol == "SIM") && (folga == "SIM")){
//     Console.WriteLine($"Vou para a praia");
// } else {
//     Console.WriteLine($"Vou trabalhar");
// }


// Condicional encadedada
int idade = 18;

if (idade >= 18) {
    Console.WriteLine($"Pode entrar na festa. Beba com moderação.");
} else if (idade >= 16 && idade <18 ) {
    Console.WriteLine($"Pode entrar na festa, com o seu responsável.");
} else {
    Console.WriteLine($"Vai brincar por aí, criança.");
}