// Faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:

// Telefonou para a vítima?"


// "Esteve no local do crime?"


// "Mora perto da vítima?"


// "Devia para a vítima?"


// "Já trabalhou com a vítima?"

// O programa deve no final emitir uma classificação sobre a participação da pessoa no crime.
// Se a pessoa responder positivamente a 2 questões ela deve ser classificada como "Suspeita",
// entre 3 e 4 como "Cúmplice" e 5 como “Culpado“. Caso contrário, ele será classificado como "Inocente“.

// se 0 ou 1 questoes = sim, inoscente.
// se 2 questoes = sim, suspeita.
// se 3 ou 4 questoes = sim, cumplice.
// se 5 questoes = sim, culpado.

int contador = 0;
Console.WriteLine($"Responda com sim ou não.");

Console.WriteLine($"Esteve no local do crime?");
string q1 = Console.ReadLine()!.ToUpper();
if (q1 == "SIM"){
    contador ++;
}

Console.WriteLine($"Telefonou para a vítima?");
string q2 = Console.ReadLine()!.ToUpper();
if (q2 == "SIM"){
    contador ++;
}

Console.WriteLine($"Mora perto da vítima?");
string q3 = Console.ReadLine()!.ToUpper();
if (q3 == "SIM"){
    contador ++;
}

Console.WriteLine($"Devia para a vítima?");
string q4 = Console.ReadLine()!.ToUpper();
if (q4 == "SIM") {
    contador ++;
}

Console.WriteLine($"Já trabalhou com a vítima?");
string q5 = Console.ReadLine()!.ToUpper();
if (q5 == "SIM"){
    contador ++;
}



if (contador == 5) {
    Console.WriteLine($"CULPADO!");
    
} else if (contador >= 3) {
    Console.WriteLine($"CÚMPLICE.");
    
} else if (contador == 2) {
    Console.WriteLine($"Suspeito.");
    
} else {
    Console.WriteLine($"Inoscente.");
    
}