// Fazer um programa onde pergunte:
// Nome diferente de vazio. nome != ""
// Idade de 0 a 100. idade <= 100
// Salário maior que zero. salario > 0
// Estado civil, sendo Solteiro/a (s), Casado/a (c), Viúvo/a (v) ou Divorciada (d).

Console.WriteLine(@$"

    INSIRA OS SEUS DADOS
    
");

bool nomeIn = false;
while (nomeIn == false) {
    Console.WriteLine($"Nome: ");
    string nome = Console.ReadLine()!;
    
    if (nome == ""){
        Console.WriteLine($"O campo está nulo! insira seu Nome!");
    } else {
        nomeIn = true;
    }
}

bool idadeIn = false;
while (idadeIn == false) {
    Console.WriteLine($"Idade:");
    int idade = int.Parse(Console.ReadLine()!);

    if (idade <= 100){
        idadeIn = true;
    } else {
        Console.WriteLine($"Idade inválida");
    }
}

bool salarioIn = false;
while (salarioIn == false) {
    Console.WriteLine($"Salário: ");
    float salario = float.Parse(Console.ReadLine()!);  

    if (salario == 0) {
        Console.WriteLine($"Salário não pode ser igual a zero.");
    } else {
        salarioIn = true;
    }
}

bool estadoIn = false;
while (estadoIn == false) {
    Console.WriteLine(@$"Estado Civil, sendo que:
    Casado/a = c
    Solteiro/a = s
    VIúvo/a = v
    Divorciado/a = d
    ");
    char estado = char.Parse(Console.ReadLine()!);

    if ((estado == 'c') || (estado == 's') || (estado == 'v') || (estado == 'd')) {
        estadoIn = true;
    } else {
        Console.WriteLine($"Caracter inválido");
    }
}